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
        public AddMarqueForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            String marque = MarqueTxtbox.Text;

            //Ajouter article to DB
            DBManager.GetInstance().AjouterMarqueToDB(marque);

            this.Close();
        }
    }
}
