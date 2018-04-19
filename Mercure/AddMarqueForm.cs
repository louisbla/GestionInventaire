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
    public partial class AddMarqueForm : Form
    {
        private Marque marque;

        public AddMarqueForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor used to edit a Marque
        /// </summary>
        /// <param name="marqueToEdit">Marque information with will fill the form</param>
        public AddMarqueForm(Marque marqueToEdit)
        {
            InitializeComponent();

            this.Text = "Modifier une marque";

            marque = marqueToEdit;
            MarqueTxtbox.Text = marqueToEdit.Nom;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (MarqueTxtbox.Text != "")
            {
                String nom = MarqueTxtbox.Text;

                if (marque != null)
                {
                    DBManager.GetInstance().EditMarque(marque, nom);
                }
                else {
                    DBManager.GetInstance().AjouterMarqueToDB(nom);
                }
                this.Close();
            }
        }
    }
}
