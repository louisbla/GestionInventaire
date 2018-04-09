﻿using System;
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
            
            prixNum.DecimalPlaces = 2;
            prixNum.Increment = 0.01M;

            //On récupère l'article correspondant à la référence
            Article article = DBManager.GetInstance().GetArticleFromReference(reference);

            //On ajoute les données de la BDD aux combobox
            sousFamilleCombo.Items.AddRange(DBManager.GetInstance().GetListSousFamille());
            marqueCombo.Items.AddRange(DBManager.GetInstance().GetListMarques());

            //On modifie les textbox avec les données de l'article récupéré
            referenceTxtBox.Text = article.RefArticle;
            descriptionTxtBox.Text = article.Description;
            sousFamilleCombo.Text = article.SousFamille;
            marqueCombo.Text = article.Marque;
            prixNum.Text = article.PrixHT.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //on récupère les textbox
            String reference = referenceTxtBox.Text;
            Article article = DBManager.GetInstance().GetArticleFromReference(reference);

            article.Description = descriptionTxtBox.Text;
            article.SousFamille = sousFamilleCombo.Text;
            article.Marque = marqueCombo.Text;
            article.PrixHT = (float)prixNum.Value;

            //on envoie les données à la base de données
            DBManager.GetInstance().AjouterArticleToDB(article);

            this.Close();
        }
    }
}
