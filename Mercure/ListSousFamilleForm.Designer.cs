namespace Mercure
{
    partial class ListSousFamilleForm
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
            this.sousfamilleListview = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
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
            this.sousfamilleListview.Location = new System.Drawing.Point(0, 0);
            this.sousfamilleListview.MultiSelect = false;
            this.sousfamilleListview.Name = "sousfamilleListview";
            this.sousfamilleListview.Size = new System.Drawing.Size(800, 450);
            this.sousfamilleListview.TabIndex = 1;
            this.sousfamilleListview.UseCompatibleStateImageBehavior = false;
            this.sousfamilleListview.View = System.Windows.Forms.View.Details;
            this.sousfamilleListview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sousfamilleListview_KeyDown);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "RefSousFamille";
            this.columnHeader11.Width = 114;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ListSousFamilleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sousfamilleListview);
            this.Name = "ListSousFamilleForm";
            this.Text = "ListSousFamilleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView sousfamilleListview;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}