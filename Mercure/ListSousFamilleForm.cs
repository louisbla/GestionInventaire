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
            RefreshListView();
        }

        private void sousfamilleListview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && sousfamilleListview.SelectedIndices.Count == 1)
            {
                if (DialogResult.OK == MessageBox.Show("Attention, vous êtes sur le point de supprimer une sous-famille, et tous les articles associés à cette sous-famille. \n Etes vous sur de vouloir continuer ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    int SelectedIndex = sousfamilleListview.SelectedIndices[0];
                    String refSousFamilleToDelete = this.sousfamilleListview.Items[SelectedIndex].SubItems[0].Text;
                    SousFamille sousfamille = DBManager.GetInstance().GetSousFamilleByRef(refSousFamilleToDelete);
               
                    //Suppression des articles de la sous famille
                    DBManager.GetInstance().DeleteArticlesBySousFamille(Int32.Parse(refSousFamilleToDelete));
                
                    DBManager.GetInstance().DeleteSousFamille(sousfamille);

                    RefreshListView();
                }
            }

            else if (e.KeyCode == Keys.F5)
            {
                RefreshListView();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (sousfamilleListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = sousfamilleListview.SelectedIndices[0];
                    String refSousFamilleToEdit = this.sousfamilleListview.Items[SelectedIndex].SubItems[0].Text;
                    SousFamille sousfamille = DBManager.GetInstance().GetSousFamilleByRef(refSousFamilleToEdit);


                    AddSousFamilleForm form = new AddSousFamilleForm(sousfamille);
                    form.ShowDialog();
                    RefreshListView();
                }
            }
        }

        private void RefreshListView()
        {
            sousfamilleListview.Items.Clear();

            List<String[]> listSousFamilles = DBManager.GetInstance().GetListSousFamilles();
            foreach (String[] sousFamille in listSousFamilles)
            {
                ListViewItem item = new ListViewItem(sousFamille);
                sousfamilleListview.Items.Add(item);
            }

            if (sousfamilleListview.Items.Count == 0)
            {
                sousfamilleListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                sousfamilleListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                sousfamilleListview.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ajouterUneSousfamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSousFamilleForm form = new AddSousFamilleForm();
            form.ShowDialog();
            RefreshListView();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sousfamilleListview.SelectedIndices.Count == 1)
            {
                int SelectedIndex = sousfamilleListview.SelectedIndices[0];
                String refSousFamilleToEdit = this.sousfamilleListview.Items[SelectedIndex].SubItems[0].Text;
                SousFamille sousfamille = DBManager.GetInstance().GetSousFamilleByRef(refSousFamilleToEdit);

                AddSousFamilleForm form = new AddSousFamilleForm(sousfamille);
                form.ShowDialog();
                RefreshListView();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Attention, vous êtes sur le point de supprimer une sous-famille, et tous les articles associés à cette sous-famille. \n Etes vous sur de vouloir continuer ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                int SelectedIndex = sousfamilleListview.SelectedIndices[0];
                String refSousFamilleToDelete = this.sousfamilleListview.Items[SelectedIndex].SubItems[0].Text;
                SousFamille sousfamille = DBManager.GetInstance().GetSousFamilleByRef(refSousFamilleToDelete);

                //Suppression des articles de la sous famille
                DBManager.GetInstance().DeleteArticlesBySousFamille(Int32.Parse(refSousFamilleToDelete));

                //Supprimer toutes les sous familles associées à la famille
                DBManager.GetInstance().DeleteSousFamillesByFamille(refSousFamilleToDelete);

                DBManager.GetInstance().DeleteSousFamille(sousfamille);

                RefreshListView();
            }
        }

        private void sousfamilleListview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sousfamilleListview.SelectedIndices.Count == 1)
            {
                int SelectedIndex = sousfamilleListview.SelectedIndices[0];
                String refSousFamilleToEdit = this.sousfamilleListview.Items[SelectedIndex].SubItems[0].Text;
                SousFamille sousfamille = DBManager.GetInstance().GetSousFamilleByRef(refSousFamilleToEdit);

                AddSousFamilleForm form = new AddSousFamilleForm(sousfamille);
                form.ShowDialog();
                RefreshListView();
            }
        }
    }
}
