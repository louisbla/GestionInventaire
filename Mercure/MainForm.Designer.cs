﻿namespace Mercure
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionnerFichierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.effacerLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionnerFichierXMLToolStripMenuItem,
            this.effacerLaBaseDeDonnéesToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // selectionnerFichierXMLToolStripMenuItem
            // 
            this.selectionnerFichierXMLToolStripMenuItem.Name = "selectionnerFichierXMLToolStripMenuItem";
            this.selectionnerFichierXMLToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.selectionnerFichierXMLToolStripMenuItem.Text = "Selectionner fichier XML";
            this.selectionnerFichierXMLToolStripMenuItem.Click += new System.EventHandler(this.SelectionnerFichierXMLToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1080, 402);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RefArticle";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marque";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Famille";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sous famille";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "PrixHT";
            // 
            // effacerLaBaseDeDonnéesToolStripMenuItem
            // 
            this.effacerLaBaseDeDonnéesToolStripMenuItem.Name = "effacerLaBaseDeDonnéesToolStripMenuItem";
            this.effacerLaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.effacerLaBaseDeDonnéesToolStripMenuItem.Text = "Effacer la Base de données";
            this.effacerLaBaseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.EffacerLaBaseDeDonnéesToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articleToolStripMenuItem,
            this.marqueToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.sousfamilleToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.articleToolStripMenuItem.Text = "Article";
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.marqueToolStripMenuItem.Text = "Marque";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // sousfamilleToolStripMenuItem
            // 
            this.sousfamilleToolStripMenuItem.Name = "sousfamilleToolStripMenuItem";
            this.sousfamilleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sousfamilleToolStripMenuItem.Text = "Sous-famille";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 452);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Gestion d\'inventaire";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionnerFichierXMLToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem effacerLaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sousfamilleToolStripMenuItem;
    }
}