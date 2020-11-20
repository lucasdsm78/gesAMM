namespace gsb_gesAMM
{
    partial class frmMedAuto
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
            this.lvListMed = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvListMedAuto = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvListMed
            // 
            this.lvListMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvListMed.FullRowSelect = true;
            this.lvListMed.Location = new System.Drawing.Point(13, 13);
            this.lvListMed.Name = "lvListMed";
            this.lvListMed.Size = new System.Drawing.Size(775, 168);
            this.lvListMed.TabIndex = 0;
            this.lvListMed.UseCompatibleStateImageBehavior = false;
            this.lvListMed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code famille";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Designation famille";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NB médicaments autorisés";
            this.columnHeader3.Width = 150;
            // 
            // lvListMedAuto
            // 
            this.lvListMedAuto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvListMedAuto.Location = new System.Drawing.Point(13, 187);
            this.lvListMedAuto.Name = "lvListMedAuto";
            this.lvListMedAuto.Size = new System.Drawing.Size(775, 206);
            this.lvListMedAuto.TabIndex = 1;
            this.lvListMedAuto.UseCompatibleStateImageBehavior = false;
            this.lvListMedAuto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dépot légale";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nom commerciale";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Composition";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Effets";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Contre Indic";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "AMM";
            this.columnHeader9.Width = 120;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(292, 405);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(187, 33);
            this.btQuitter.TabIndex = 4;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            // 
            // frmMedAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.lvListMedAuto);
            this.Controls.Add(this.lvListMed);
            this.Name = "frmMedAuto";
            this.Text = "Consulter médicament autorisé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvListMed;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvListMedAuto;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btQuitter;
    }
}