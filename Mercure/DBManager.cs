using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mercure
{
    class DBManager
    {
        private static DBManager instance = null;
        private static SQLiteConnection sqlConn;

        private DBManager()
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
        }

        public static SQLiteConnection GetConnection()
        {
            return sqlConn;
        }

        public Article GetArticleFromReference(String reference)
        {
            Article article = new Article();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT a.Description, a.RefArticle, m.Nom as 'Marque', f.Nom as 'Famille', sf.Nom as 'Sous-famille', a.PrixHT FROM Articles a, Marques m, SousFamilles sf, Familles f WHERE a.RefMarque = m.RefMarque AND a.RefSousFamille = sf.RefSousFamille AND sf.RefFamille = f.RefFamille AND a.RefArticle = @ref", sqlConn);
            SQLiteParameter param = new SQLiteParameter("@ref", reference);
            sqlCmd.Parameters.Add(param);
            
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if(reader.Read())
            {
                article.Description = reader.GetString(0);
                article.RefArticle = reader.GetString(1);
                article.Marque = reader.GetString(2);
                article.Famille = reader.GetString(3);
                article.SousFamille = reader.GetString(4);
                article.PrixHT = float.Parse(reader.GetString(5));
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();


            return article;
        }

        public static DBManager GetInstance()
        {
                if (instance == null)
                {
                    instance = new DBManager();
                }
                return instance;
        }

        /// <summary>
        /// Retourne la liste d'articles en DB, et met à jour la barre de progression
        /// </summary>
        public void AjouterListToDB(List<string> list, SelectionXML fenetre)
        {
            fenetre.ResetNbArticles();

            fenetre.SetProgressBarMaximumValue(list.Count / 6);
            fenetre.SetProgressBarValue(0);

            String RefArticle;
            String Description;
            String Marque;
            String SousFamille;
            String Famille;
            String Prix;

            String query;

            for (int i = 0; i < list.Count; i = i + 6)
            {
                fenetre.IncrementProgressBarValue();

                Description = list[i];
                RefArticle = list[i + 1];
                Marque = list[i + 2];
                SousFamille = list[i + 3];
                Famille = list[i + 4];
                Prix = list[i + 5];

                //est-ce que la famille existe ?
                int idFamille = ReturnID(Famille, "Famille");
                if (idFamille == 0) //Si la famille n'existe pas
                {
                    //je recupere l'id max de la table dans idFamille et j'ajoute la famille
                    idFamille = ReturnIdMax("Famille") + 1;
                    query = "INSERT INTO Familles VALUES(" + idFamille + " , '" + Famille + "')";
                    InsertQuery(query, fenetre);

                }

                //est-ce que la sous famille existe ?
                int idSousFamille = ReturnID(SousFamille, "SousFamille");
                if (idSousFamille == 0)
                {
                    //je recupere l'id max de la table dans idSousFamille et j'ajoute la sousfamille
                    idSousFamille = ReturnIdMax("SousFamille") + 1;
                    query = "INSERT INTO SousFamilles VALUES(" + idSousFamille + " , " + idFamille + ",'" + SousFamille + "')";
                    InsertQuery(query, fenetre);
                }

                //est-ce que la marque existe ?
                int idMarque = ReturnID(Marque, "Marque");
                if (idMarque == 0)
                {
                    //je recupere l'id max de la table dans idMarque et j'ajoute la marque
                    idMarque = ReturnIdMax("Marque") + 1;
                    query = "INSERT INTO Marques VALUES(" + idMarque + " , '" + Marque + "')";
                    InsertQuery(query, fenetre);
                }

                //Ajout de l'article
                query = "INSERT INTO Articles VALUES('" + RefArticle + "' , '" + Description + "'," + idSousFamille + "," + idMarque + ",'" + Prix + "'," + 0 + ")";
                if(InsertQuery(query, fenetre))
                    fenetre.IncrementNbArticles();
            }
        }

        /// <summary>
        /// Retourne la liste d'articles presents dans la DB
        /// </summary>
        public List<string[]> GetListFromDB()
        {
            List<String[]> list = new List<string[]>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT a.Description, a.RefArticle, m.Nom as 'Marque', f.Nom as 'Famille', sf.Nom as 'Sous-famille', a.PrixHT FROM Articles a, Marques m, SousFamilles sf, Familles f WHERE a.RefMarque = m.RefMarque AND a.RefSousFamille = sf.RefSousFamille AND sf.RefFamille = f.RefFamille";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            while(reader.Read())
            {
                
                String description = reader.GetString(0);
                String refArticle = reader.GetString(1);
                String marque = reader.GetString(2);
                String famille = reader.GetString(3);
                String sousFamille = reader.GetString(4);
                String prix = reader.GetString(5);

                String[] article = { description, refArticle, marque, famille, sousFamille, prix };
                list.Add(article);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list;
        }

        private static bool InsertQuery(String query, SelectionXML fenetre)
        {
            bool isAdded = false;

            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = query;
            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText);
                isAdded = true;
            }
            catch (SQLiteException e)
            {
                fenetre.AjouterErreur(e.Message + " | " + sqlCmd.CommandText);
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();

            return isAdded;
        }

        /// <summary>
        /// Le nom de la classe doit être entré sans 's'
        /// </summary>
        private static int ReturnIdMax(String classe)
        {
            int id;

            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT MAX(Ref" + classe + ") FROM " + classe + "s";  //on ajoute un 's' 
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader.IsDBNull(0))
                    id = 0;
                else
                    id = reader.GetInt32(0);
            }
            else
            {
                id = 0;
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return id;
        }

        /// <summary>
        /// Le nom de la classe doit être entré sans 's'
        /// </summary>
        private static int ReturnID(String objet, String classe)
        {
            int id;

            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT Ref" + classe + " FROM " + classe + "s WHERE Nom = '" + objet + "'";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            else
            {
                id = 0;
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return id;
        }

        /// <summary>
        /// Supprime un article a partir d'une ref d'article
        /// </summary>
        public void DeleteArticle(String refArticleToDelete)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From Articles Where RefArticle = '" + refArticleToDelete + "'";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }
    }
}
