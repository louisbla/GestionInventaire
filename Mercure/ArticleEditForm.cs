using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure
{
    public partial class ArticleEditForm : Form
    {
        public ArticleEditForm(String reference)
        {
            InitializeComponent();

            //On récupère l'article correspondant à la référence
            Article article = DBManager.GetInstance().GetArticleFromReference(reference);

            //On ajoute les données de la BDD aux combobox
            sousFamilleCombo.Items.Add("rien");
            marqueCombo.Items.Add("rien");

            //On modifie les textbox avec les données de l'article récupéré
            referenceTxtBox.Text = article.RefArticle;
            descriptionTxtBox.Text = article.Description;
            sousFamilleCombo.Text = "rien";
            marqueCombo.Text = "rien";
            prixNum.Text = article.PrixHT.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //on récupère les textbox
            
            //on vérifie que les données sont bonnes

            //on envoie les données à la base de données


            this.Close();
        }
    }
}
