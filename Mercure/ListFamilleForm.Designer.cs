namespace Mercure
{
    partial class ListFamilleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.familleListview = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // familleListview
            // 
            this.familleListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.familleListview.ContextMenuStrip = this.contextMenuStrip1;
            this.familleListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.familleListview.FullRowSelect = true;
            this.familleListview.GridLines = true;
            this.familleListview.Location = new System.Drawing.Point(0, 0);
            this.familleListview.MultiSelect = false;
            this.familleListview.Name = "familleListview";
            this.familleListview.Size = new System.Drawing.Size(800, 450);
            this.familleListview.TabIndex = 1;
            this.familleListview.UseCompatibleStateImageBehavior = false;
            this.familleListview.View = System.Windows.Forms.View.Details;
            this.familleListview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.familleListview_KeyDown);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "RefFamille";
            this.columnHeader9.Width = 79;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nom";
            this.columnHeader10.Width = 138;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneFamilleToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 76);
            // 
            // ajouterUneFamilleToolStripMenuItem
            // 
            this.ajouterUneFamilleToolStripMenuItem.Name = "ajouterUneFamilleToolStripMenuItem";
            this.ajouterUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.ajouterUneFamilleToolStripMenuItem.Text = "Ajouter une famille";
            this.ajouterUneFamilleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneFamilleToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // ListFamilleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.familleListview);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "ListFamilleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des familles";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListFamilleForm_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView familleListview;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}