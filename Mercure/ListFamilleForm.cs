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
    public partial class ListFamilleForm : Form
    {
        public ListFamilleForm()
        {
            InitializeComponent();
        }

        private void ListFamilleForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void RefreshListView()
        {
            List<String[]> listFamilles = DBManager.GetInstance().GetListFamilles();
            foreach (String[] famille in listFamilles)
            {
                ListViewItem item = new ListViewItem(famille);

                familleListview.Items.Add(item);
            }
        }
    }
}
