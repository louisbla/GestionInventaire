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
        private SousFamille sousFamille;

        public AddSousFamilleForm()
        {
            InitializeComponent();

            familleCombobox.Items.AddRange(DBManager.GetInstance().GetFamilleNames());
            if(familleCombobox.Items.Count != 0)
                familleCombobox.SelectedIndex = 0;
        }

        public AddSousFamilleForm(SousFamille sousfamilleToEdit)
        {
            InitializeComponent();

            this.Text = "Modifier une sous-famille";

            sousFamille = sousfamilleToEdit;
            sousFamilleTxtbox.Text = sousfamilleToEdit.Nom;

            familleCombobox.Items.AddRange(DBManager.GetInstance().GetFamilleNames());
            familleCombobox.SelectedIndex = familleCombobox.Items.IndexOf(DBManager.GetInstance().GetFamilleByRef(sousfamilleToEdit.RefFamille.ToString()).Nom);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (sousFamilleTxtbox.Text != "" && familleCombobox.Text != "")
            {
                if (sousFamille != null)
                {
                    sousFamille.Nom = sousFamilleTxtbox.Text;
                    sousFamille.RefFamille = DBManager.GetInstance().getRefFamille(familleCombobox.Text);

                    //edit sous famille in DB
                    DBManager.GetInstance().EditSousFamille(sousFamille);
                }
                else
                {
                    sousFamille = new SousFamille();
                    sousFamille.Nom = sousFamilleTxtbox.Text;
                    sousFamille.RefFamille = DBManager.GetInstance().getRefFamille(familleCombobox.Text);

                    //Ajouter sous famille to DB
                    DBManager.GetInstance().AjouterSousFamilleToDB(sousFamille.Nom, familleCombobox.Text);
                }

                this.Close();
            }
        }
    }
}
