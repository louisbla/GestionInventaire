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
    
    public partial class AddFamilleForm : Form
    {
        private Famille famille;

        public AddFamilleForm()
        {
            InitializeComponent();
        }

        public AddFamilleForm(Famille familleToEdit)
        {
            InitializeComponent();

            this.Text = "Modifier une famille";

            famille = familleToEdit;
            FamilleTxtbox.Text = familleToEdit.Nom;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (FamilleTxtbox.Text != "")
            {
                String nom = FamilleTxtbox.Text;

                if (famille != null)
                {
                    DBManager.GetInstance().EditFamille(famille, nom);
                }
                else
                {
                    DBManager.GetInstance().AjouterFamilleToDB(nom);
                }
                this.Close();
            }
        }
    }
}
