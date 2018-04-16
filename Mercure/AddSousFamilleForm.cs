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
    public partial class AddSousFamilleForm : Form
    {
        private SousFamille sousfamille;

        public AddSousFamilleForm()
        {
            InitializeComponent();

            familleCombobox.Items.AddRange(DBManager.GetInstance().GetFamilleNames());
            familleCombobox.SelectedIndex = 1;
        }

        public AddSousFamilleForm(SousFamille sousfamilleToEdit)
        {
            InitializeComponent();

            this.Text = "Modifier une sous-famille";

            sousfamille = sousfamilleToEdit;
            sousFamilleTxtbox.Text = sousfamilleToEdit.Nom;

            familleCombobox.Items.AddRange(DBManager.GetInstance().GetFamilleNames());
            familleCombobox.SelectedIndex = familleCombobox.Items.IndexOf(sousfamilleToEdit.Nom);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            String sousFamille = sousFamilleTxtbox.Text;
            String famille = familleCombobox.Text;

            //Ajouter article to DB
            DBManager.GetInstance().AjouterSousFamilleToDB(sousFamille, famille);


            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
