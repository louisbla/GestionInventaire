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

            refreshListWiew();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listView1.SelectedIndices.Count == 1)
            {
                int SelectedIndex = listView1.SelectedIndices[0];
                String refArticleToDelete = this.listView1.Items[SelectedIndex].SubItems[1].Text;

                DBManager.GetInstance().DeleteArticle(refArticleToDelete);

                refreshListWiew();
            }

            else if (e.KeyCode == Keys.F5)
            {
                refreshListWiew();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if (listView1.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = listView1.SelectedIndices[0];
                    String refArticleToEdit = this.listView1.Items[SelectedIndex].SubItems[1].Text;

                    ArticleEditForm form = new ArticleEditForm(refArticleToEdit);
                    form.ShowDialog();
                }
            }
        }

        private void effacerLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Attention, êtes-vous sur de vouloir effacer la base de données ?",
                "Effacer la Base de données", MessageBoxButtons.YesNo , 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBManager.GetInstance().ViderDB();
                refreshListWiew();
       
            }

        }

        private void refreshListWiew()
        {
            listView1.Items.Clear();

            List<String[]> listArticles = DBManager.GetInstance().GetListFromDB();

            foreach (String[] article in listArticles)
            {
                ListViewItem itemArticle = new ListViewItem(article);
                listView1.Items.Add(itemArticle);
            }
        }
    }
}
