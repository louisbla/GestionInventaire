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
        public AddFamilleForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            String famille = FamilleTxtbox.Text;

            //Ajouter article to DB
            DBManager.GetInstance().AjouterFamilleToDB(famille);

            this.Close();
        }
    }
}
