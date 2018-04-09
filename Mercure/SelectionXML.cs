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
using System.Xml;




namespace Mercure
{
    public partial class SelectionXML : Form
    {
        String filename = null;
        bool isPathEntered = false;
        List<String> list = new List<string>();

        public SelectionXML()
        {
            InitializeComponent();
        }


        private void Btn_Parcourir_XML_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Fichiers XML (.xml)|*.xml";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                isPathEntered = true;
                Txtbox_Path.Text = open.FileName;
                filename = open.FileName;
            }
        }

        private void Btn_Integration_Click(object sender, EventArgs e)
        {
            if (RBtn_MAJ.Checked == true && isPathEntered == true)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(filename);

                foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
                {
                    foreach (XmlNode node2 in node)
                    {
                        list.Add(node2.InnerText);
                    }
                }


                DBManager.GetInstance().AjouterListToDB(list, this);

                //this.Close();
            }
            else if (RBtn_New_Integration.Checked == true && isPathEntered == true)
            {
                Txtbox_Path.Text = "New";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un fichier");
            }
        }



        public void SetProgressBarMaximumValue(int value)
        {
            progressBar.Maximum = value;
        }

        public void SetProgressBarValue(int value)
        {
            progressBar.Value = value;
        }

        public void IncrementProgressBarValue()
        {
            progressBar.Value++;
        }

        public void AjouterErreur(String erreur)
        {
            ListViewItem item = new ListViewItem(erreur);
            listViewErrors.Items.Add(item);
        }

        public void IncrementNbArticles()
        {
            labelNbArticles.Text = (Int32.Parse(labelNbArticles.Text) + 1).ToString();
        }

        public void ResetNbArticles()
        {
            labelNbArticles.Text = "0";
        }
    }
}
