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
            RefreshListView();
        }

        private void ListFamilleForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /// <summary>
        /// Refresh,update the listview
        /// </summary>
        private void RefreshListView()
        {
            familleListview.Items.Clear();

            List<String[]> listFamilles = DBManager.GetInstance().GetListFamilles();
            foreach (String[] famille in listFamilles)
            {
                ListViewItem item = new ListViewItem(famille);

                familleListview.Items.Add(item);
            }
            if (familleListview.Items.Count == 0)
            {
                familleListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                familleListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                familleListview.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void familleListview_KeyDown(object sender, KeyEventArgs e)
        {
            //Si on appuie sur la touche "suppr" et qu'une famille et sélectionnée
            if (e.KeyCode == Keys.Delete && familleListview.SelectedIndices.Count == 1)
            {
                //Si on appuie sur OK sur la fenetre de warning
                if (DialogResult.OK == MessageBox.Show("Attention, vous êtes sur le point de supprimer une famille, et tous les articles et sous familles associés à cette famille. \n Etes vous sur de vouloir continuer ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    int SelectedIndex = familleListview.SelectedIndices[0];
                    String refFamilleToDelete = this.familleListview.Items[SelectedIndex].SubItems[0].Text;
                    Famille famille = DBManager.GetInstance().GetFamilleByRef(refFamilleToDelete);
                    List<SousFamille> sousFamilles = new List<SousFamille>();

                    //Supprimer tous les articles liées au sous-familles qui appartiennent à la famille
                    sousFamilles = DBManager.GetInstance().GetListeSousFamillesByFamille(refFamilleToDelete);
                    for(int i =0; i < sousFamilles.Count; i++) //Pour chaque sous famille
                    {
                        DBManager.GetInstance().DeleteArticlesBySousFamille(sousFamilles[i].RefSousFamille);
                    }
                    
                    //Supprimer toutes les sous familles associées à la famille
                    DBManager.GetInstance().DeleteSousFamillesByFamille(refFamilleToDelete);

                    //Supprimer la famille
                    DBManager.GetInstance().DeleteFamille(famille);

                    RefreshListView();
                }
            }

            else if (e.KeyCode == Keys.F5)
            {
                RefreshListView();
            }
            //Si on appuie sur "entrer" pour modifier
            else if (e.KeyCode == Keys.Enter)
            {
                if (familleListview.SelectedIndices.Count == 1)
                {
                    int SelectedIndex = familleListview.SelectedIndices[0];
                    String refFamilleToEdit = this.familleListview.Items[SelectedIndex].SubItems[0].Text;
                    Famille famille = DBManager.GetInstance().GetFamilleByRef(refFamilleToEdit);

                    AddFamilleForm form = new AddFamilleForm(famille);
                    form.ShowDialog();
                    RefreshListView();
                }
            }
        }
  
        private void ajouterUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFamilleForm form = new AddFamilleForm();
            form.ShowDialog();
            RefreshListView();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familleListview.SelectedIndices.Count == 1)
            {
                int SelectedIndex = familleListview.SelectedIndices[0];
                String refFamilleToEdit = this.familleListview.Items[SelectedIndex].SubItems[0].Text;
                Famille famille = DBManager.GetInstance().GetFamilleByRef(refFamilleToEdit);

                AddFamilleForm form = new AddFamilleForm(famille);
                form.ShowDialog();
                RefreshListView();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familleListview.SelectedIndices.Count == 1)
            {
                if (DialogResult.OK == MessageBox.Show("Attention, vous êtes sur le point de supprimer une famille, et tous les articles et sous familles associés à cette famille. \n Etes vous sur de vouloir continuer ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    int SelectedIndex = familleListview.SelectedIndices[0];
                    String refFamilleToDelete = this.familleListview.Items[SelectedIndex].SubItems[0].Text;
                    Famille famille = DBManager.GetInstance().GetFamilleByRef(refFamilleToDelete);
                    List<SousFamille> sousFamilles = new List<SousFamille>();

                    //Supprimer tous les articles liées au sous-familles qui appartiennent à la famille
                    sousFamilles = DBManager.GetInstance().GetListeSousFamillesByFamille(refFamilleToDelete);
                    for (int i = 0; i < sousFamilles.Count; i++) //Pour chaque sous famille
                    {
                        DBManager.GetInstance().DeleteArticlesBySousFamille(sousFamilles[i].RefSousFamille);
                    }

                    //Supprimer toutes les sous familles associées à la famille
                    DBManager.GetInstance().DeleteSousFamillesByFamille(refFamilleToDelete);

                    //Supprimer la famille
                    DBManager.GetInstance().DeleteFamille(famille);

                    RefreshListView();
                }
            }
        }
    }
}
