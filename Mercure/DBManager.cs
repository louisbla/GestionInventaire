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

        /// <summary>
        /// Get a family thanks to its name
        /// </summary>
        /// <param name="nom">Family name</param>
        /// <returns>Famille object</returns>
           public int getRefFamille(string nom)
        {
            int refFamille = 0;

            //Ouverture de la BDD et préparation de la requete
            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT RefFamille FROM Familles WHERE Nom = @Nom", sqlConn);
            sqlCmd.Parameters.Add(new SQLiteParameter("@Nom", nom));

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                refFamille = reader.GetInt32(0);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return refFamille;
        }

        /// <summary>
        /// Edit a brand (change its name)
        /// </summary>
        /// <param name="marque">Object name to edit</param>
        /// <param name="nom">New name</param>
        internal void EditMarque(Marque marque, string nom)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("UPDATE Marques SET RefMarque = @RefMarque, Nom = @Nom WHERE RefMarque = @RefMarque;", sqlConn);

            sqlCmd.Parameters.Add(new SQLiteParameter("@RefMarque", marque.RefMarque));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Nom", nom));

            Console.WriteLine(sqlCmd.CommandText);

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }

        /// <summary>
        /// Edit a sous famille
        /// </summary>
        /// <param name="sousFamille">New object new sous-famille which will remplace the old one</param>
        internal void EditSousFamille(SousFamille sousFamille)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("UPDATE SousFamilles SET Nom = @Nom, RefFamille = @RefFamille WHERE RefSousFamille = @RefSousFamille;", sqlConn);

            sqlCmd.Parameters.Add(new SQLiteParameter("@RefSousFamille", sousFamille.RefSousFamille));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Nom", sousFamille.Nom));
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", sousFamille.RefFamille));

            Console.WriteLine(sqlCmd.CommandText);

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }

        /// <summary>
        /// Edit an article
        /// </summary>
        /// <param name="article">New object article which will remplace the old one</param>
        internal void EditArticle(Article article)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("UPDATE Articles SET RefArticle = @RefArticle, Description = @Description, RefSousFamille = @RefSousFamille, RefMarque = @RefMarque, PrixHT = @Prix WHERE RefArticle = @RefArticle;", sqlConn);

            sqlCmd.Parameters.Add(new SQLiteParameter("@RefArticle", article.RefArticle));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Description", article.Description));
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefSousFamille", ReturnID(article.SousFamille, "SousFamille")));
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefMarque", ReturnID(article.Marque, "Marque")));
            String prix = article.PrixHT.ToString();
            if (!prix.Contains(".") && !prix.Contains(","))
                prix = prix + ",00";
            prix = prix.Replace('.', ',');
            sqlCmd.Parameters.Add(new SQLiteParameter("@Prix", prix));

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText + sqlCmd.Parameters[4]);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }

        /// <summary>
        /// Edit a famille (just its name)
        /// </summary>
        /// <param name="famille">Old object name to edit</param>
        /// <param name="nom">New name</param>
        internal void EditFamille(Famille famille, string nom)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("UPDATE Familles SET RefFamille = @RefFamille, Nom = @Nom WHERE RefFamille = @RefFamille;", sqlConn);

            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", famille.RefFamille));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Nom", nom));

            Console.WriteLine(sqlCmd.CommandText);

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }

        /// <summary>
        /// Get a family object thanks to its reference.
        /// </summary>
        public Famille GetFamilleByRef(string refFamilleToEdit)
        {
            Famille famille = new Famille();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT RefFamille, Nom FROM Familles WHERE RefFamille = @RefFamille", sqlConn);
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", refFamilleToEdit));

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                famille.RefFamille = reader.GetInt32(0);
                famille.Nom = reader.GetString(1);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return famille;
        }

        /// <summary>
        /// Get a sous-famille object thanks to its reference.
        /// </summary>
        public SousFamille GetSousFamilleByRef(string refSousFamille)
        {
            SousFamille sousfamille = new SousFamille();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT RefFamille, RefSousFamille, Nom FROM SousFamilles WHERE RefSousFamille = @RefSousFamille", sqlConn);
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefSousFamille", refSousFamille));

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                sousfamille.RefFamille = reader.GetInt32(0);
                sousfamille.RefSousFamille = reader.GetInt32(1);
                sousfamille.Nom = reader.GetString(2);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return sousfamille;
        }

        /// <summary>
        /// Get all sous-familles that belong to a family
        /// </summary>
        /// <param name="refFamille">Family name</param>
        /// <returns>A list of "sous-famille"</returns>
        public List<SousFamille> GetListeSousFamillesByFamille(string refFamille)
        {
            Famille famille = new Famille();
            SousFamille sousFamille = new SousFamille();
            List<SousFamille> listSousFamilles = new List<SousFamille>();

            sqlConn.Open();

            //Compter combien de résultat la requete retourne
            int nbResults = 0;
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT COUNT(*) FROM SousFamilles WHERE RefFamille = @RefFamille", sqlConn);
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", refFamille));

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if (reader.Read())
                nbResults = reader.GetInt16(0);

            reader.Close();
            reader.Dispose();


            //Récupération des sous-familles
            sqlCmd = new SQLiteCommand("SELECT RefSousFamille, RefFamille, Nom FROM SousFamilles WHERE RefFamille = @RefFamille", sqlConn);
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", refFamille));

            reader = sqlCmd.ExecuteReader();

            if (reader.Read())
            {
                //On boucle sur le nombre de résultats obtenus
                for(int i=0; i < nbResults; i++)
                {
                    sousFamille.RefSousFamille = reader.GetInt32(0);
                    sousFamille.RefFamille = reader.GetInt32(1);
                    sousFamille.Nom = reader.GetString(2);

                    listSousFamilles.Add(sousFamille);
                }
                
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return listSousFamilles;
        }

        /// <summary>
        /// Get an brand thanks to its reference
        /// </summary>
        /// <param name="reference">reference (ID) of the brand</param>
        /// <returns>Returns an object Marque</returns>
        public Marque GetMarqueByRef(string refMarqueToEdit)
        {
            Marque marque = new Marque();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT RefMarque, Nom FROM Marques WHERE RefMarque = @RefMarque", sqlConn);
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefMarque", refMarqueToEdit));

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            if(reader.Read())
            {
                marque.RefMarque = reader.GetInt32(0);
                marque.Nom = reader.GetString(1);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return marque;
        }

      
        /// <summary>
        /// Get an article thanks to its reference
        /// </summary>
        /// <param name="reference">reference (ID) of the article</param>
        /// <returns>Returns an object Article</returns>
        public Article GetArticleFromReference(String reference)
        {
            Article article = new Article();

            sqlConn.Open();

            //Requête 
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

        /// <summary>
        /// Add a brand to the DB
        /// </summary>
        /// <param name="marque">brand name we want to add</param>
        internal void AjouterMarqueToDB(string marque)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("INSERT INTO Marques VALUES(@RefMarque, @Nom);", sqlConn);

            //On récupère l'id max présent dans la table marque
            int id = ReturnIdMax("Marque");
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefMarque", id + 1));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Nom", marque));

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }

        /// <summary>
        /// Add a family to the DB
        /// </summary>
        /// <param name="famille">Family name we want to add</param>
        internal void AjouterFamilleToDB(string famille)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("INSERT INTO Familles VALUES(@RefFamille, @Nom);", sqlConn);

            int id = ReturnIdMax("Famille");
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", id + 1));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Nom", famille));

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }


        /// <summary>
        /// Delete all articles related to a sous famille
        /// </summary>
        public void DeleteArticlesBySousFamille(int refSousFamilleToDelete)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From Articles WHERE RefSousFamille = @RefSousFamille";
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefSousFamille", refSousFamilleToDelete));
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }

        /// <summary>
        /// Delete all sous-familles that belong to a family
        /// </summary>
        public void DeleteSousFamillesByFamille(string refFamilleToDelete)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From SousFamilles WHERE RefFamille = @RefFamille";
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", refFamilleToDelete));
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }

        
        /// <summary>
        /// Delete all articles related to a brand
        /// </summary>
        public void DeleteArticlesByMarque(string refMarqueToDelete)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From Articles WHERE RefMarque = @RefMarque";
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefMarque", refMarqueToDelete));
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }

        /// <summary>
        /// Add a 'sous-famille' to the DB
        /// </summary>
        /// <param name="sousFamille">'sous-famille' name we want to add</param>
        /// <param name="famille">Family name to which the 'sous-famille' belongs</param>
        internal void AjouterSousFamilleToDB(string sousFamille, string famille)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("INSERT INTO SousFamilles VALUES(@RefSousFamille, @RefFamille, @Nom);", sqlConn);

            int id = ReturnIdMax("SousFamille");
            int idFamille = ReturnID(famille, "Famille");
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefSousFamille", id+1));
            sqlCmd.Parameters.Add(new SQLiteParameter("@RefFamille", idFamille));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Nom", sousFamille));

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }

        /// <summary>
        /// Get all articles
        /// </summary>
        /// <returns>Returns a list of articles : { RedfArcticle, description,marque,famille,sousFamille,prix }</returns>
        public List<string[]> GetListArticles()
        {
            List<String[]> list = new List<string[]>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT a.Description, a.RefArticle, m.Nom as 'Marque', f.Nom as 'Famille', sf.Nom as 'Sous-famille', a.PrixHT FROM Articles a, Marques m, SousFamilles sf, Familles f WHERE a.RefMarque = m.RefMarque AND a.RefSousFamille = sf.RefSousFamille AND sf.RefFamille = f.RefFamille";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            //Tant qu'on lit une ligne
            while (reader.Read())
            {
                String description = reader.GetString(0);
                String refArticle = reader.GetString(1);
                String marque = reader.GetString(2);
                String famille = reader.GetString(3);
                String sousFamille = reader.GetString(4);
                String prix = reader.GetString(5);

                String[] article = { description, refArticle, marque, famille, sousFamille, prix.ToString() };
                list.Add(article);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list;
        }

        /// <summary>
        /// Get all brands
        /// </summary>
        /// <returns> Returns a list of brands : { RefMarque, Nom }</returns>
        public List<String[]> GetListMarques()
        {
            List<String[]> list = new List<string[]>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT RefMarque, Nom FROM Marques", sqlConn);

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                String[] marque = { reader.GetInt32(0).ToString(), reader.GetString(1) };
                list.Add(marque);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list;
        }

        /// <summary>
        /// Get all families
        /// </summary>
        /// <returns> Returns a list of families : { RefFamille, Nom }</returns>
        public List<String[]> GetListFamilles()
        {
            List<String[]> list = new List<string[]>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT RefFamille, Nom FROM Familles", sqlConn);

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                String[] famille = { reader.GetInt32(0).ToString(), reader.GetString(1) };
                list.Add(famille);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list;
        }

        /// <summary>
        /// Get all "sous-familles"
        /// </summary>
        /// <returns>Return a list of 'sous-familles' : { RefSousFamille, Nom }</returns>
        public List<String[]> GetListSousFamilles()
        {
            List<String[]> list = new List<string[]>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT sf.RefSousFamille, sf.Nom, f.Nom FROM Familles f, SousFamilles sf WHERE f.RefFamille = sf.RefFamille", sqlConn);

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                String[] sousFamille = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2) };
                list.Add(sousFamille);
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list;
        }

        /// <summary>
        /// Returns all the brand names in the database
        /// </summary>
        public String[] GetMarquesNames()
        {
            List<String> list = new List<String>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT Nom FROM Marques", sqlConn);

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list.ToArray();
        }

        /// <summary>
        /// Return all families names in the database
        /// </summary>
        public String[] GetFamilleNames()
        {
            List<String> list = new List<String>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT Nom FROM Familles", sqlConn);

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list.ToArray();
        }

        /// <summary>
        /// Return all 'sous-famille' names in the database
        /// </summary>
        public String[] GetSousFamilleNames()
        {
            List<String> list = new List<String>();

            sqlConn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand("SELECT Nom FROM SousFamilles", sqlConn);

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }

            reader.Close();
            reader.Dispose();
            sqlConn.Close();

            return list.ToArray();
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
        /// Add an article to the DB
        /// </summary>
        /// <param name="article">article to add</param>
        internal void AjouterArticleToDB(Article article)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");

            SQLiteCommand sqlCmd = new SQLiteCommand("INSERT INTO Articles VALUES(@RefArticle, @Description,@idSousFamille, @idMarque, @Prix,0);", sqlConn);

            sqlCmd.Parameters.Add(new SQLiteParameter("@RefArticle", article.RefArticle));
            sqlCmd.Parameters.Add(new SQLiteParameter("@Description", article.Description));
            sqlCmd.Parameters.Add(new SQLiteParameter("@idSousFamille", ReturnID(article.SousFamille, "SousFamille")));
            sqlCmd.Parameters.Add(new SQLiteParameter("@IdMarque", ReturnID(article.Marque, "Marque")));
            String prix = article.PrixHT.ToString();
            if (!prix.Contains(".") && !prix.Contains(","))
                prix = prix + ",00";
            prix = prix.Replace('.', ',');
            sqlCmd.Parameters.Add(new SQLiteParameter("@Prix", prix));

            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SQLiteTransaction trans = sqlConn.BeginTransaction();
            try
            {
                Console.WriteLine(sqlCmd.ExecuteNonQuery() + " : " + sqlCmd.CommandText + sqlCmd.Parameters[4]);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(sqlCmd.CommandText);
                Console.WriteLine(e.Message);
            }
            trans.Commit();
            sqlConn.Close();
        }

        /// <summary>
        /// Empty the DB, delete all rows.
        /// </summary>
        public void ViderDB()
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From Articles; Delete From Marques; Delete From SousFamilles; Delete From Familles";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }

        /// <summary>
        /// Add an article list to the DB and update progression bar
        /// </summary>
        /// <param name="list"> Arcticle list</param>
        /// <param name="fenetre">Window where the progression bar is</param>
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
        /// Execute an insertion Query
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="fenetre">Window in which the listView error will be modified</param>
        /// <returns></returns>
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
        /// Return the max ID of the table 
        /// </summary>
        /// <param name="classe">Table concerned. She has to be entered without 's' at the end</param>
        /// <returns> Return an the ID max as int</returns>
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
        /// Return the ID of the object of the table.
        /// </summary>
        /// <param name="objet">Object we want to know his ID</param>
        /// <param name="classe">Table in which the table is.</param>
        /// <returns>Return an the ID as int</returns>
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
        /// Delete an article from the DB
        /// </summary>
        /// <param name="refArticleToDelete">The reference (ID) of the article we want to delete</param>
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

        /// <summary>
        /// Delete an brand from the DB
        /// </summary>
        /// <param name="refMarqueToDelete">The reference (ID) of the brand we want to delete</param>
        internal void DeleteMarque(Marque marque)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From Marques Where RefMarque = '" + marque.RefMarque + "'";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            Console.WriteLine(sqlCmd.CommandText);

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }

        /// <summary>
        /// Delete an family from the DB
        /// </summary>
        internal void DeleteFamille(Famille famille)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From Familles Where RefFamille = '" + famille.RefFamille + "'";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            Console.WriteLine(sqlCmd.CommandText);

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }

        /// <summary>
        /// Delete an sous-famille from the DB
        /// </summary>
        internal void DeleteSousFamille(SousFamille sousfamille)
        {
            sqlConn = new SQLiteConnection("Data Source=Mercure.SQLite;");
            sqlConn.Open();
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "Delete From SousFamilles Where RefSousFamille = '" + sousfamille.RefSousFamille + "'";
            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            Console.WriteLine(sqlCmd.CommandText);

            reader.Close();
            reader.Dispose();
            sqlConn.Close();
        }
    }
}
