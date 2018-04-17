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

            RefreshListView();
        }


        private void EffacerLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Attention, êtes-vous sur de vouloir vider la base de données ?",
                "Vider la Base de données", MessageBoxButtons.YesNo , 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBManager.GetInstance().ViderDB();
                RefreshListView();
       
            }

        }

        private void RefreshListView()
        {
            articleListview.Items.Clear();

            List<String[]> listArticles = DBManager.GetInstance().GetListArticles();
            foreach (String[] article in listArticles)
            {
                ListViewItem itemArticle = new ListViewItem(article);
                articleListview.Items.Add(itemArticle);
            }
        }

        private void MarqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMarqueForm form = new AddMarqueForm();
            form.ShowDialog();
            RefreshListView();
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
            if (articleListview.SelectedIndices.Count == 1)
            {
                int SelectedIndex = articleListview.SelectedIndices[0];
                String refArticleToEdit = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                AddArticleForm form = new AddArticleForm(refArticleToEdit);
                form.ShowDialog();
                RefreshListView();
            }
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

                    RefreshListView();
                }

            }

            else if (e.KeyCode == Keys.F5)
            {
                RefreshListView();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (articleListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = articleListview.SelectedIndices[0];
                    String refArticleToEdit = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                    AddArticleForm form = new AddArticleForm(refArticleToEdit);
                    form.ShowDialog();
                    RefreshListView();
                }
            }
        }

        private void supprimerArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (articleListview.SelectedIndices.Count == 1)
            {
                if (articleListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = articleListview.SelectedIndices[0];
                    String refArticleToDelete = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                    DBManager.GetInstance().DeleteArticle(refArticleToDelete);

                    RefreshListView();
                }
            }
        }

        private void marquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListMarqueForm form = new ListMarqueForm();
            form.ShowDialog();
        }

        private void famillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFamilleForm form = new ListFamilleForm();
            form.ShowDialog();
        }

        private void sousFamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListSousFamilleForm form = new ListSousFamilleForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Gestion du double click sur le listview des articles
        /// </summary>
        private void articleListview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (articleListview.SelectedIndices.Count == 1)
            {
                int SelectedIndex = articleListview.SelectedIndices[0];
                String refArticleToEdit = this.articleListview.Items[SelectedIndex].SubItems[1].Text;

                AddArticleForm form = new AddArticleForm(refArticleToEdit);
                form.ShowDialog();
                RefreshListView();
            }
        }

        private void ajouterArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArticleForm form = new AddArticleForm();
            form.ShowDialog();
            RefreshListView();
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArticleForm form = new AddArticleForm();
            form.ShowDialog();
            RefreshListView();
        }

        private void articleListview_SizeChanged(object sender, EventArgs e)
        {
            articleListview.Columns[0].Width = articleListview.Width / 6;
            articleListview.Columns[1].Width = articleListview.Width / 6;
            articleListview.Columns[2].Width = articleListview.Width / 6;
            articleListview.Columns[3].Width = articleListview.Width / 6;
            articleListview.Columns[4].Width = articleListview.Width / 6;
            articleListview.Columns[5].Width = articleListview.Width / 6;
        }
    }
}
