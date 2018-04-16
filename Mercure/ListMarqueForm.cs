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
    public partial class ListMarqueForm : Form
    {
        public ListMarqueForm()
        {
            InitializeComponent();
            RefreshListView();
        }

        private void marqueListview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && marqueListview.SelectedIndices.Count == 1)
            {
                if (DialogResult.OK == MessageBox.Show("Attention, vous êtes sur le point de supprimer une marque, et tous les articles associés à cette marque. \n Etes vous sur de vouloir continuer ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    int SelectedIndex = marqueListview.SelectedIndices[0];
                    String refMarqueToDelete = this.marqueListview.Items[SelectedIndex].SubItems[0].Text;
                    Marque marque = DBManager.GetInstance().GetMarqueByRef(refMarqueToDelete);

                    //Supprimer tous les articles associés à la marque
                    DBManager.GetInstance().DeleteArticlesByMarque(refMarqueToDelete);

                    DBManager.GetInstance().DeleteMarque(marque);

                    RefreshListView();
                }
            }

            else if (e.KeyCode == Keys.F5)
            {
                RefreshListView();

            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (marqueListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = marqueListview.SelectedIndices[0];
                    String refMarqueToEdit = this.marqueListview.Items[SelectedIndex].SubItems[0].Text;
                    Marque marque = DBManager.GetInstance().GetMarqueByRef(refMarqueToEdit);
                
                    AddMarqueForm form = new AddMarqueForm(marque);
                    form.ShowDialog();
                    RefreshListView();
                }
            }
        }

        private void RefreshListView()
        {
            marqueListview.Items.Clear();

            List<String[]> listMarques = DBManager.GetInstance().GetListMarques();
            foreach (String[] marque in listMarques)
            {
                ListViewItem item = new ListViewItem(marque);

                marqueListview.Items.Add(item);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marqueListview.SelectedIndices.Count == 1)
            {
                int SelectedIndex = marqueListview.SelectedIndices[0];
                String refMarqueToEdit = this.marqueListview.Items[SelectedIndex].SubItems[0].Text;
                Marque marque = DBManager.GetInstance().GetMarqueByRef(refMarqueToEdit);

                AddMarqueForm form = new AddMarqueForm(marque);
                form.ShowDialog();
                RefreshListView();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marqueListview.SelectedIndices.Count == 1)
            {
                if (DialogResult.OK == MessageBox.Show("Attention, vous êtes sur le point de supprimer une marque, et tous les articles associés à cette marque. \n Etes vous sur de vouloir continuer ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    int SelectedIndex = marqueListview.SelectedIndices[0];
                    String refMarqueToDelete = this.marqueListview.Items[SelectedIndex].SubItems[0].Text;
                    Marque marque = DBManager.GetInstance().GetMarqueByRef(refMarqueToDelete);

                    //Supprimer tous les articles associés à la marque
                    DBManager.GetInstance().DeleteArticlesByMarque(refMarqueToDelete);
                    
                    DBManager.GetInstance().DeleteMarque(marque);

                    RefreshListView();
                }
            }
        }

        private void ajouterUneMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMarqueForm form = new AddMarqueForm();
            form.ShowDialog();
            RefreshListView();

        }
    }
}
