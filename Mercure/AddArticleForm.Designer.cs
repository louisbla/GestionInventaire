﻿namespace Mercure
{
    partial class AddArticleForm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.referenceTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.sousFamilleCombo = new System.Windows.Forms.ComboBox();
            this.marqueCombo = new System.Windows.Forms.ComboBox();
            this.prixNum = new System.Windows.Forms.NumericUpDown();
            this.quantiteNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prixNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteNum)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.acceptButton.Location = new System.Drawing.Point(109, 347);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(116, 35);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Valider";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prix HT :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Référence : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marque :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sous-famille :";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelButton.Location = new System.Drawing.Point(253, 347);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 35);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // referenceTxtBox
            // 
            this.referenceTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.referenceTxtBox.Enabled = false;
            this.referenceTxtBox.Location = new System.Drawing.Point(126, 27);
            this.referenceTxtBox.Name = "referenceTxtBox";
            this.referenceTxtBox.Size = new System.Drawing.Size(314, 22);
            this.referenceTxtBox.TabIndex = 7;
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionTxtBox.Location = new System.Drawing.Point(126, 70);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(314, 71);
            this.descriptionTxtBox.TabIndex = 8;
            // 
            // sousFamilleCombo
            // 
            this.sousFamilleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sousFamilleCombo.FormattingEnabled = true;
            this.sousFamilleCombo.Location = new System.Drawing.Point(128, 157);
            this.sousFamilleCombo.Name = "sousFamilleCombo";
            this.sousFamilleCombo.Size = new System.Drawing.Size(314, 24);
            this.sousFamilleCombo.TabIndex = 9;
            // 
            // marqueCombo
            // 
            this.marqueCombo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.marqueCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marqueCombo.FormattingEnabled = true;
            this.marqueCombo.Location = new System.Drawing.Point(128, 198);
            this.marqueCombo.Name = "marqueCombo";
            this.marqueCombo.Size = new System.Drawing.Size(314, 24);
            this.marqueCombo.TabIndex = 10;
            // 
            // prixNum
            // 
            this.prixNum.Location = new System.Drawing.Point(128, 246);
            this.prixNum.Name = "prixNum";
            this.prixNum.Size = new System.Drawing.Size(120, 22);
            this.prixNum.TabIndex = 11;
            // 
            // quantiteNum
            // 
            this.quantiteNum.Location = new System.Drawing.Point(126, 291);
            this.quantiteNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.quantiteNum.Name = "quantiteNum";
            this.quantiteNum.Size = new System.Drawing.Size(120, 22);
            this.quantiteNum.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantité : ";
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 400);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantiteNum);
            this.Controls.Add(this.prixNum);
            this.Controls.Add(this.marqueCombo);
            this.Controls.Add(this.sousFamilleCombo);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.referenceTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(482, 447);
            this.MinimumSize = new System.Drawing.Size(482, 447);
            this.Name = "AddArticleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editer un article";
            ((System.ComponentModel.ISupportInitialize)(this.prixNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox referenceTxtBox;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.ComboBox sousFamilleCombo;
        private System.Windows.Forms.ComboBox marqueCombo;
        private System.Windows.Forms.NumericUpDown prixNum;
        private System.Windows.Forms.NumericUpDown quantiteNum;
        private System.Windows.Forms.Label label6;
    }
}