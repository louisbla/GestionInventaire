namespace Mercure
{
    partial class SelectionXML
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
            this.Btn_Parcourir_XML = new System.Windows.Forms.Button();
            this.Btn_Integration = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Txtbox_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBtn_New_Integration = new System.Windows.Forms.RadioButton();
            this.RBtn_MAJ = new System.Windows.Forms.RadioButton();
            this.listViewErrors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNbArticles = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Parcourir_XML
            // 
            this.Btn_Parcourir_XML.Location = new System.Drawing.Point(574, 24);
            this.Btn_Parcourir_XML.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Parcourir_XML.Name = "Btn_Parcourir_XML";
            this.Btn_Parcourir_XML.Size = new System.Drawing.Size(100, 28);
            this.Btn_Parcourir_XML.TabIndex = 0;
            this.Btn_Parcourir_XML.Text = "Parcourir";
            this.Btn_Parcourir_XML.UseVisualStyleBackColor = true;
            this.Btn_Parcourir_XML.Click += new System.EventHandler(this.Btn_Parcourir_XML_Click);
            // 
            // Btn_Integration
            // 
            this.Btn_Integration.Location = new System.Drawing.Point(64, 149);
            this.Btn_Integration.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Integration.Name = "Btn_Integration";
            this.Btn_Integration.Size = new System.Drawing.Size(204, 28);
            this.Btn_Integration.TabIndex = 1;
            this.Btn_Integration.Text = "Lancer intégration";
            this.Btn_Integration.UseVisualStyleBackColor = true;
            this.Btn_Integration.Click += new System.EventHandler(this.Btn_Integration_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(300, 149);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(310, 28);
            this.progressBar.TabIndex = 2;
            // 
            // Txtbox_Path
            // 
            this.Txtbox_Path.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txtbox_Path.Location = new System.Drawing.Point(64, 28);
            this.Txtbox_Path.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbox_Path.Name = "Txtbox_Path";
            this.Txtbox_Path.ReadOnly = true;
            this.Txtbox_Path.Size = new System.Drawing.Size(501, 22);
            this.Txtbox_Path.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fichier :";
            // 
            // RBtn_New_Integration
            // 
            this.RBtn_New_Integration.AutoSize = true;
            this.RBtn_New_Integration.Location = new System.Drawing.Point(64, 104);
            this.RBtn_New_Integration.Margin = new System.Windows.Forms.Padding(4);
            this.RBtn_New_Integration.Name = "RBtn_New_Integration";
            this.RBtn_New_Integration.Size = new System.Drawing.Size(377, 21);
            this.RBtn_New_Integration.TabIndex = 6;
            this.RBtn_New_Integration.Text = "Nouvelle intégration (supprime les anciennes données)";
            this.RBtn_New_Integration.UseVisualStyleBackColor = true;
            // 
            // RBtn_MAJ
            // 
            this.RBtn_MAJ.AutoSize = true;
            this.RBtn_MAJ.Checked = true;
            this.RBtn_MAJ.Location = new System.Drawing.Point(64, 76);
            this.RBtn_MAJ.Margin = new System.Windows.Forms.Padding(4);
            this.RBtn_MAJ.Name = "RBtn_MAJ";
            this.RBtn_MAJ.Size = new System.Drawing.Size(98, 21);
            this.RBtn_MAJ.TabIndex = 7;
            this.RBtn_MAJ.TabStop = true;
            this.RBtn_MAJ.Text = "Mise à jour";
            this.RBtn_MAJ.UseVisualStyleBackColor = true;
            // 
            // listViewErrors
            // 
            this.listViewErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewErrors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewErrors.Location = new System.Drawing.Point(6, 21);
            this.listViewErrors.Name = "listViewErrors";
            this.listViewErrors.Size = new System.Drawing.Size(1105, 199);
            this.listViewErrors.TabIndex = 8;
            this.listViewErrors.UseCompatibleStateImageBehavior = false;
            this.listViewErrors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Erreur";
            this.columnHeader1.Width = 1200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewErrors);
            this.groupBox1.Location = new System.Drawing.Point(15, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 226);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Erreurs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre d\'articles ajoutés : ";
            // 
            // labelNbArticles
            // 
            this.labelNbArticles.AutoSize = true;
            this.labelNbArticles.Location = new System.Drawing.Point(198, 222);
            this.labelNbArticles.Name = "labelNbArticles";
            this.labelNbArticles.Size = new System.Drawing.Size(16, 17);
            this.labelNbArticles.TabIndex = 13;
            this.labelNbArticles.Text = "0";
            // 
            // SelectionXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 480);
            this.Controls.Add(this.labelNbArticles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RBtn_MAJ);
            this.Controls.Add(this.RBtn_New_Integration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtbox_Path);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Btn_Integration);
            this.Controls.Add(this.Btn_Parcourir_XML);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectionXML";
            this.Text = "SelectionXML";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Parcourir_XML;
        private System.Windows.Forms.Button Btn_Integration;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox Txtbox_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBtn_New_Integration;
        private System.Windows.Forms.RadioButton RBtn_MAJ;
        private System.Windows.Forms.ListView listViewErrors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNbArticles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}