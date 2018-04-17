namespace Mercure
{
    partial class ListMarqueForm
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
            this.marqueListview = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marqueListview
            // 
            this.marqueListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.marqueListview.ContextMenuStrip = this.contextMenuStrip1;
            this.marqueListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marqueListview.FullRowSelect = true;
            this.marqueListview.GridLines = true;
            this.marqueListview.Location = new System.Drawing.Point(0, 0);
            this.marqueListview.MultiSelect = false;
            this.marqueListview.Name = "marqueListview";
            this.marqueListview.Size = new System.Drawing.Size(800, 450);
            this.marqueListview.TabIndex = 1;
            this.marqueListview.UseCompatibleStateImageBehavior = false;
            this.marqueListview.View = System.Windows.Forms.View.Details;
            this.marqueListview.DoubleClick += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            this.marqueListview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.marqueListview_KeyDown);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "RefMarque";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nom";
            this.columnHeader8.Width = 157;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneMarqueToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 76);
            // 
            // ajouterUneMarqueToolStripMenuItem
            // 
            this.ajouterUneMarqueToolStripMenuItem.Name = "ajouterUneMarqueToolStripMenuItem";
            this.ajouterUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ajouterUneMarqueToolStripMenuItem.Text = "Ajouter une marque";
            this.ajouterUneMarqueToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneMarqueToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // ListMarqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.marqueListview);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "ListMarqueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des marques";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView marqueListview;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}