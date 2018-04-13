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
    public partial class ListSousFamilleForm : Form
    {
        public ListSousFamilleForm()
        {
            InitializeComponent();
        }

        private void sousfamilleListview_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void RefreshListView()
        {
            List<String[]> listSousFamilles = DBManager.GetInstance().GetListSousFamilles();
            foreach (String[] sousFamille in listSousFamilles)
            {
                ListViewItem item = new ListViewItem(sousFamille);
                sousfamilleListview.Items.Add(item);
            }
        }
    }
}
