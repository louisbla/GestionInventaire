using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectionnerFichierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionXML selectionXML = new SelectionXML();
            selectionXML.ShowDialog();

            RefreshListWiew();
        }


        private void EffacerLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Attention, êtes-vous sur de vouloir effacer la base de données ?",
                "Effacer la Base de données", MessageBoxButtons.YesNo , 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBManager.GetInstance().ViderDB();
                RefreshListWiew();
       
            }

        }

        private void RefreshListWiew()
        {
            articleListview.Items.Clear();
            marqueListview.Items.Clear();
            familleListview.Items.Clear();
            sousfamilleListview.Items.Clear();


            List<String[]> listArticles = DBManager.GetInstance().GetListArticles();
            foreach (String[] article in listArticles)
            {
                ListViewItem itemArticle = new ListViewItem(article);
                articleListview.Items.Add(itemArticle);
            }

            List<String[]> listMarques = DBManager.GetInstance().GetListMarques();
            foreach (String[] marque in listMarques)
            {
                ListViewItem item = new ListViewItem(marque);

                marqueListview.Items.Add(item);
            }

            List<String[]> listFamilles = DBManager.GetInstance().GetListFamilles();
            foreach (String[] famille in listFamilles)
            {
                ListViewItem item = new ListViewItem(famille);

                familleListview.Items.Add(item);
            }

            List<String[]> listSousFamilles = DBManager.GetInstance().GetListSousFamilles();
            foreach (String[] sousFamille in listSousFamilles)
            {
                ListViewItem item = new ListViewItem(sousFamille);
                sousfamilleListview.Items.Add(item);
            }
        }

        private void ArticleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ArticleEditForm form = new ArticleEditForm();
            form.ShowDialog();
            RefreshListWiew();
        }

        private void MarqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMarqueForm form = new AddMarqueForm();
            form.ShowDialog();
            RefreshListWiew();
        }

        private void FamilleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddFamilleForm form = new AddFamilleForm();
            form.ShowDialog();
        }

        private void SousfamilleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddSousFamilleForm form = new AddSousFamilleForm();
            form.ShowDialog();
        }

        private void ModifierArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine( e.ToString());
        }

        /// <summary>
        /// Gestion de l'appuie de touche sur le listview des articles
        /// </summary>
        private void ArticleListview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (articleListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = articleListview.SelectedIndices[0];
                    String refArticleToDelete = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                    DBManager.GetInstance().DeleteArticle(refArticleToDelete);

                    RefreshListWiew();
                }

            }

            else if (e.KeyCode == Keys.F5)
            {
                RefreshListWiew();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (articleListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = articleListview.SelectedIndices[0];
                    String refArticleToEdit = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                    ArticleEditForm form = new ArticleEditForm(refArticleToEdit);
                    form.ShowDialog();
                    RefreshListWiew();
                }
            }
        }

        /// <summary>
        /// Gestion du double click sur le listview des articles
        /// </summary>
        private void ArticleListview_DoubleClick(object sender, EventArgs e)
        {
            if (articleListview.SelectedIndices.Count == 1)
            {
                int SelectedIndex = articleListview.SelectedIndices[0];
                String refArticleToEdit = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                ArticleEditForm form = new ArticleEditForm(refArticleToEdit);
                form.ShowDialog();
                RefreshListWiew();
            }
        }

        /// <summary>
        /// Gestion de l'appuie de touche sur le listview des marques
        /// </summary>
        private void MarqueListview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && marqueListview.SelectedIndices.Count == 1)
            {
                if(DialogResult.OK == MessageBox.Show("Attention, vous êtes sur le point de supprimer une marque, et tous les articles associés à cette marque. \n Etes vous sur de vouloir continuer ?", "Attention", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning))
                {
                    //TODO : Supprimer tous les articles associés à la marque


                    int SelectedIndex = marqueListview.SelectedIndices[0];
                    String refMarqueToDelete = this.marqueListview.Items[SelectedIndex].SubItems[1].Text;

                    DBManager.GetInstance().DeleteMarque(refMarqueToDelete);

                    RefreshListWiew();
                }
            }

            else if (e.KeyCode == Keys.F5)
            {
                RefreshListWiew();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (articleListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = articleListview.SelectedIndices[0];
                    String refArticleToEdit = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                    ArticleEditForm form = new ArticleEditForm(refArticleToEdit);
                    form.ShowDialog();
                    RefreshListWiew();
                }
            }
        }
    }
}
