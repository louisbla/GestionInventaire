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

            //On modifie les textbox avec les données de l'article récupéré
            referenceTxtBox.Text = article.RefArticle;
            descriptionTxtBox.Text = article.Description;
            sousfamilleTxtBox.Text = article.SousFamille;
            MarqueTxtBox.Text = article.Marque;
            prixTxtBox.Text = article.PrixHT.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //on récupère les textbox
            

            //on envoie les données à la base de données


            this.Close();
        }
    }
}
