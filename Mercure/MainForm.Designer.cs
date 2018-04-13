namespace Mercure
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionnerFichierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.articleContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sousfamilleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.articleTab = new System.Windows.Forms.TabPage();
            this.articleListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marqueTab = new System.Windows.Forms.TabPage();
            this.marqueListview = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.familleTab = new System.Windows.Forms.TabPage();
            this.familleListview = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sousFamilleTab = new System.Windows.Forms.TabPage();
            this.sousfamilleListview = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marqueContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.articleContextMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.articleTab.SuspendLayout();
            this.marqueTab.SuspendLayout();
            this.familleTab.SuspendLayout();
            this.sousFamilleTab.SuspendLayout();
            this.marqueContextMenu.SuspendLayout();
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
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.articleToolStripMenuItem.Text = "Article";
            this.articleToolStripMenuItem.Click += new System.EventHandler(this.ArticleToolStripMenuItem1_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.marqueToolStripMenuItem.Text = "Marque";
            this.marqueToolStripMenuItem.Click += new System.EventHandler(this.MarqueToolStripMenuItem1_Click);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.familleToolStripMenuItem.Text = "Famille";
            this.familleToolStripMenuItem.Click += new System.EventHandler(this.FamilleToolStripMenuItem1_Click);
            // 
            // sousfamilleToolStripMenuItem
            // 
            this.sousfamilleToolStripMenuItem.Name = "sousfamilleToolStripMenuItem";
            this.sousfamilleToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.sousfamilleToolStripMenuItem.Text = "Sous-famille";
            this.sousfamilleToolStripMenuItem.Click += new System.EventHandler(this.SousfamilleToolStripMenuItem1_Click);
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
            // articleContextMenu
            // 
            this.articleContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.articleContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterArticleToolStripMenuItem,
            this.modifierArticleToolStripMenuItem,
            this.supprimerArticleToolStripMenuItem});
            this.articleContextMenu.Name = "contextMenuStrip1";
            this.articleContextMenu.Size = new System.Drawing.Size(193, 76);
            // 
            // ajouterArticleToolStripMenuItem
            // 
            this.ajouterArticleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articleToolStripMenuItem1,
            this.sousfamilleToolStripMenuItem1,
            this.familleToolStripMenuItem1,
            this.marqueToolStripMenuItem1});
            this.ajouterArticleToolStripMenuItem.Name = "ajouterArticleToolStripMenuItem";
            this.ajouterArticleToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.ajouterArticleToolStripMenuItem.Text = "Ajouter";
            // 
            // articleToolStripMenuItem1
            // 
            this.articleToolStripMenuItem1.Name = "articleToolStripMenuItem1";
            this.articleToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.articleToolStripMenuItem1.Text = "Article";
            this.articleToolStripMenuItem1.Click += new System.EventHandler(this.ArticleToolStripMenuItem1_Click);
            // 
            // sousfamilleToolStripMenuItem1
            // 
            this.sousfamilleToolStripMenuItem1.Name = "sousfamilleToolStripMenuItem1";
            this.sousfamilleToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.sousfamilleToolStripMenuItem1.Text = "Sous-famille";
            this.sousfamilleToolStripMenuItem1.Click += new System.EventHandler(this.SousfamilleToolStripMenuItem1_Click);
            // 
            // familleToolStripMenuItem1
            // 
            this.familleToolStripMenuItem1.Name = "familleToolStripMenuItem1";
            this.familleToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.familleToolStripMenuItem1.Text = "Famille";
            this.familleToolStripMenuItem1.Click += new System.EventHandler(this.FamilleToolStripMenuItem1_Click);
            // 
            // marqueToolStripMenuItem1
            // 
            this.marqueToolStripMenuItem1.Name = "marqueToolStripMenuItem1";
            this.marqueToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.marqueToolStripMenuItem1.Text = "Marque";
            this.marqueToolStripMenuItem1.Click += new System.EventHandler(this.MarqueToolStripMenuItem1_Click);
            // 
            // modifierArticleToolStripMenuItem
            // 
            this.modifierArticleToolStripMenuItem.Name = "modifierArticleToolStripMenuItem";
            this.modifierArticleToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.modifierArticleToolStripMenuItem.Text = "Modifier article";
            this.modifierArticleToolStripMenuItem.Click += new System.EventHandler(this.ModifierArticleToolStripMenuItem_Click);
            // 
            // supprimerArticleToolStripMenuItem
            // 
            this.supprimerArticleToolStripMenuItem.Name = "supprimerArticleToolStripMenuItem";
            this.supprimerArticleToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.supprimerArticleToolStripMenuItem.Text = "Supprimer article";
            this.supprimerArticleToolStripMenuItem.Click += new System.EventHandler(this.supprimerArticleToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.articleTab);
            this.tabControl1.Controls.Add(this.marqueTab);
            this.tabControl1.Controls.Add(this.familleTab);
            this.tabControl1.Controls.Add(this.sousFamilleTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 402);
            this.tabControl1.TabIndex = 2;
            // 
            // articleTab
            // 
            this.articleTab.Controls.Add(this.articleListview);
            this.articleTab.Location = new System.Drawing.Point(4, 25);
            this.articleTab.Name = "articleTab";
            this.articleTab.Padding = new System.Windows.Forms.Padding(3);
            this.articleTab.Size = new System.Drawing.Size(1072, 373);
            this.articleTab.TabIndex = 0;
            this.articleTab.Text = "Articles";
            this.articleTab.UseVisualStyleBackColor = true;
            // 
            // articleListview
            // 
            this.articleListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.articleListview.ContextMenuStrip = this.articleContextMenu;
            this.articleListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articleListview.FullRowSelect = true;
            this.articleListview.GridLines = true;
            this.articleListview.Location = new System.Drawing.Point(3, 3);
            this.articleListview.Margin = new System.Windows.Forms.Padding(4);
            this.articleListview.MultiSelect = false;
            this.articleListview.Name = "articleListview";
            this.articleListview.Size = new System.Drawing.Size(1066, 367);
            this.articleListview.TabIndex = 3;
            this.articleListview.UseCompatibleStateImageBehavior = false;
            this.articleListview.View = System.Windows.Forms.View.Details;
            this.articleListview.DoubleClick += new System.EventHandler(this.ArticleListview_DoubleClick);
            this.articleListview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArticleListview_KeyDown);
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
            // marqueTab
            // 
            this.marqueTab.Controls.Add(this.marqueListview);
            this.marqueTab.Location = new System.Drawing.Point(4, 25);
            this.marqueTab.Name = "marqueTab";
            this.marqueTab.Padding = new System.Windows.Forms.Padding(3);
            this.marqueTab.Size = new System.Drawing.Size(1072, 373);
            this.marqueTab.TabIndex = 1;
            this.marqueTab.Text = "Marques";
            this.marqueTab.UseVisualStyleBackColor = true;
            // 
            // marqueListview
            // 
            this.marqueListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.marqueListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marqueListview.FullRowSelect = true;
            this.marqueListview.GridLines = true;
            this.marqueListview.Location = new System.Drawing.Point(3, 3);
            this.marqueListview.MultiSelect = false;
            this.marqueListview.Name = "marqueListview";
            this.marqueListview.Size = new System.Drawing.Size(1066, 367);
            this.marqueListview.TabIndex = 0;
            this.marqueListview.UseCompatibleStateImageBehavior = false;
            this.marqueListview.View = System.Windows.Forms.View.Details;
            this.marqueListview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MarqueListview_KeyDown);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "RefMarque";
            this.columnHeader7.Width = 138;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nom";
            this.columnHeader8.Width = 157;
            // 
            // familleTab
            // 
            this.familleTab.Controls.Add(this.familleListview);
            this.familleTab.Location = new System.Drawing.Point(4, 25);
            this.familleTab.Name = "familleTab";
            this.familleTab.Padding = new System.Windows.Forms.Padding(3);
            this.familleTab.Size = new System.Drawing.Size(1072, 373);
            this.familleTab.TabIndex = 2;
            this.familleTab.Text = "Familles";
            this.familleTab.UseVisualStyleBackColor = true;
            // 
            // familleListview
            // 
            this.familleListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.familleListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.familleListview.FullRowSelect = true;
            this.familleListview.GridLines = true;
            this.familleListview.Location = new System.Drawing.Point(3, 3);
            this.familleListview.MultiSelect = false;
            this.familleListview.Name = "familleListview";
            this.familleListview.Size = new System.Drawing.Size(1066, 367);
            this.familleListview.TabIndex = 0;
            this.familleListview.UseCompatibleStateImageBehavior = false;
            this.familleListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "RefFamille";
            this.columnHeader9.Width = 166;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nom";
            this.columnHeader10.Width = 138;
            // 
            // sousFamilleTab
            // 
            this.sousFamilleTab.Controls.Add(this.sousfamilleListview);
            this.sousFamilleTab.Location = new System.Drawing.Point(4, 25);
            this.sousFamilleTab.Name = "sousFamilleTab";
            this.sousFamilleTab.Padding = new System.Windows.Forms.Padding(3);
            this.sousFamilleTab.Size = new System.Drawing.Size(1072, 373);
            this.sousFamilleTab.TabIndex = 3;
            this.sousFamilleTab.Text = "Sous familles";
            this.sousFamilleTab.UseVisualStyleBackColor = true;
            // 
            // sousfamilleListview
            // 
            this.sousfamilleListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.sousfamilleListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sousfamilleListview.FullRowSelect = true;
            this.sousfamilleListview.GridLines = true;
            this.sousfamilleListview.Location = new System.Drawing.Point(3, 3);
            this.sousfamilleListview.MultiSelect = false;
            this.sousfamilleListview.Name = "sousfamilleListview";
            this.sousfamilleListview.Size = new System.Drawing.Size(1066, 367);
            this.sousfamilleListview.TabIndex = 0;
            this.sousfamilleListview.UseCompatibleStateImageBehavior = false;
            this.sousfamilleListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "RefSousFamille";
            this.columnHeader11.Width = 137;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Nom";
            this.columnHeader12.Width = 113;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Famille";
            // 
            // marqueContextMenu
            // 
            this.marqueContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.marqueContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierMarqueToolStripMenuItem,
            this.supprimerMarqueToolStripMenuItem});
            this.marqueContextMenu.Name = "marqueContextMenu";
            this.marqueContextMenu.Size = new System.Drawing.Size(211, 104);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // modifierMarqueToolStripMenuItem
            // 
            this.modifierMarqueToolStripMenuItem.Name = "modifierMarqueToolStripMenuItem";
            this.modifierMarqueToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modifierMarqueToolStripMenuItem.Text = "Modifier marque";
            this.modifierMarqueToolStripMenuItem.Click += new System.EventHandler(this.modifierMarqueToolStripMenuItem_Click);
            // 
            // supprimerMarqueToolStripMenuItem
            // 
            this.supprimerMarqueToolStripMenuItem.Name = "supprimerMarqueToolStripMenuItem";
            this.supprimerMarqueToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.supprimerMarqueToolStripMenuItem.Text = "Supprimer marque";
            this.supprimerMarqueToolStripMenuItem.Click += new System.EventHandler(this.supprimerMarqueToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Gestion d\'inventaire";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArticleListview_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.articleContextMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.articleTab.ResumeLayout(false);
            this.marqueTab.ResumeLayout(false);
            this.familleTab.ResumeLayout(false);
            this.sousFamilleTab.ResumeLayout(false);
            this.marqueContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionnerFichierXMLToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem effacerLaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sousfamilleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip articleContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ajouterArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sousfamilleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage articleTab;
        private System.Windows.Forms.ListView articleListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage marqueTab;
        private System.Windows.Forms.TabPage familleTab;
        private System.Windows.Forms.TabPage sousFamilleTab;
        private System.Windows.Forms.ListView marqueListview;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView familleListview;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView sousfamilleListview;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ContextMenuStrip marqueContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerMarqueToolStripMenuItem;
    }
}