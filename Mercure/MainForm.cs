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

            //On vide les articles deja presents
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
