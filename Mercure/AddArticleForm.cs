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
    public partial class AddArticleForm : Form
    {
        Article article;

        /// <summary>
        /// Constructor used to edit an Article
        /// </summary>
        /// <param name="reference">Reference of the article we want to edit</param>
        public AddArticleForm(String reference)
        {
            InitializeComponent();
            
            prixNum.DecimalPlaces = 2;
            prixNum.Increment = 0.01M;

            //On récupère l'article correspondant à la référence
            article = DBManager.GetInstance().GetArticleFromReference(reference);

            //On ajoute les données de la BDD aux combobox
            sousFamilleCombo.Items.AddRange(DBManager.GetInstance().GetSousFamilleNames());
            marqueCombo.Items.AddRange(DBManager.GetInstance().GetMarquesNames());

            //On modifie les textbox avec les données de l'article récupéré
            referenceTxtBox.Text = article.RefArticle;
            descriptionTxtBox.Text = article.Description;
            sousFamilleCombo.Text = article.SousFamille;
            marqueCombo.Text = article.Marque;
            prixNum.Text = article.PrixHT.ToString();
            quantiteNum.Text = article.Quantite.ToString();
        }

        public AddArticleForm()
        {
            InitializeComponent();

            this.Text = "Ajouter un nouvel article";
            referenceTxtBox.Enabled = true;

            prixNum.DecimalPlaces = 2;
            prixNum.Increment = 0.01M;

            //On ajoute les données de la BDD aux combobox
            sousFamilleCombo.Items.AddRange(DBManager.GetInstance().GetSousFamilleNames());
            marqueCombo.Items.AddRange(DBManager.GetInstance().GetMarquesNames());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (referenceTxtBox.Text != "" && descriptionTxtBox.Text != "" && sousFamilleCombo.Text != "" && marqueCombo.Text != "")
            {
                //on récupère les textbox
                String reference = referenceTxtBox.Text;
                Article article = DBManager.GetInstance().GetArticleFromReference(reference);
                if (article.RefArticle == null)
                {
                    article.RefArticle = reference;
                    article.Description = descriptionTxtBox.Text;
                    article.SousFamille = sousFamilleCombo.Text;
                    article.Marque = marqueCombo.Text;
                    Console.WriteLine(prixNum.Value);
                    article.PrixHT = (float)decimal.ToDouble(prixNum.Value);
                    article.Quantite = decimal.ToInt32(quantiteNum.Value);

                    //on envoie les données à la base de données
                    DBManager.GetInstance().AjouterArticleToDB(article);
                }
                else
                {
                    article.Description = descriptionTxtBox.Text;
                    article.SousFamille = sousFamilleCombo.Text;
                    article.Marque = marqueCombo.Text;
                    Console.WriteLine(prixNum.Value);
                    article.PrixHT = (float)decimal.ToDouble(prixNum.Value);
                    article.Quantite = decimal.ToInt32(quantiteNum.Value);

                    //on envoie les données à la base de données
                    DBManager.GetInstance().EditArticle(article);
                }
                this.Close();
            }
        }
    }
}
