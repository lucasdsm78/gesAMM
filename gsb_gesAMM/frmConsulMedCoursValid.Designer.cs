namespace gsb_gesAMM
{
    partial class frmConsulMedCoursValid
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
            this.lvMeds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMedsWorkflow = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvMeds
            // 
            this.lvMeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMeds.FullRowSelect = true;
            this.lvMeds.HideSelection = false;
            this.lvMeds.Location = new System.Drawing.Point(16, 71);
            this.lvMeds.Margin = new System.Windows.Forms.Padding(4);
            this.lvMeds.Name = "lvMeds";
            this.lvMeds.Size = new System.Drawing.Size(388, 330);
            this.lvMeds.TabIndex = 0;
            this.lvMeds.UseCompatibleStateImageBehavior = false;
            this.lvMeds.View = System.Windows.Forms.View.Details;
            this.lvMeds.Click += new System.EventHandler(this.lvMeds_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépôt légal";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom commercial";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Libellé de la famille";
            // 
            // lvMedsWorkflow
            // 
            this.lvMedsWorkflow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMedsWorkflow.HideSelection = false;
            this.lvMedsWorkflow.Location = new System.Drawing.Point(629, 71);
            this.lvMedsWorkflow.Margin = new System.Windows.Forms.Padding(4);
            this.lvMedsWorkflow.Name = "lvMedsWorkflow";
            this.lvMedsWorkflow.Size = new System.Drawing.Size(420, 330);
            this.lvMedsWorkflow.TabIndex = 1;
            this.lvMedsWorkflow.UseCompatibleStateImageBehavior = false;
            this.lvMedsWorkflow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "n° de l\'étape";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "n° de la décision";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date de la décision";
            // 
            // frmConsulMedCoursValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lvMedsWorkflow);
            this.Controls.Add(this.lvMeds);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsulMedCoursValid";
            this.Text = "frmConsulMedCoursValid";
            this.Load += new System.EventHandler(this.frmConsulMedCoursValid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMeds;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvMedsWorkflow;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}