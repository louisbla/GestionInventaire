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
        public AddSousFamilleForm()
        {
            InitializeComponent();

            familleCombobox.Items.AddRange(DBManager.GetInstance().GetFamilleNames());
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
    }
}
