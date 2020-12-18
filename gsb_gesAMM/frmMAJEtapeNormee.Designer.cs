namespace gsb_gesAMM
{
    partial class frmMAJEtapeNormee
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
            this.lvEtapeNormee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbEtapeNormee = new System.Windows.Forms.GroupBox();
            this.tbUtilisateur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEtapeNormee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEtapeNormee
            // 
            this.lvEtapeNormee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvEtapeNormee.FullRowSelect = true;
            this.lvEtapeNormee.Location = new System.Drawing.Point(62, 57);
            this.lvEtapeNormee.Name = "lvEtapeNormee";
            this.lvEtapeNormee.Size = new System.Drawing.Size(968, 284);
            this.lvEtapeNormee.TabIndex = 0;
            this.lvEtapeNormee.UseCompatibleStateImageBehavior = false;
            this.lvEtapeNormee.View = System.Windows.Forms.View.Details;
            this.lvEtapeNormee.Click += new System.EventHandler(this.lvEtapeNormee_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "numéro étape";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "libellé étape";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "norme de l\'étape";
            this.columnHeader3.Width = 156;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "date de la norme";
            this.columnHeader4.Width = 216;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "utilisateur";
            this.columnHeader5.Width = 126;
            // 
            // gbEtapeNormee
            // 
            this.gbEtapeNormee.Controls.Add(this.tbUtilisateur);
            this.gbEtapeNormee.Controls.Add(this.label3);
            this.gbEtapeNormee.Controls.Add(this.btModifier);
            this.gbEtapeNormee.Controls.Add(this.tbDateNorme);
            this.gbEtapeNormee.Controls.Add(this.label2);
            this.gbEtapeNormee.Controls.Add(this.tbNorme);
            this.gbEtapeNormee.Controls.Add(this.label1);
            this.gbEtapeNormee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEtapeNormee.Location = new System.Drawing.Point(122, 357);
            this.gbEtapeNormee.Name = "gbEtapeNormee";
            this.gbEtapeNormee.Size = new System.Drawing.Size(628, 352);
            this.gbEtapeNormee.TabIndex = 1;
            this.gbEtapeNormee.TabStop = false;
            this.gbEtapeNormee.Text = "Etape Normée";
            // 
            // tbUtilisateur
            // 
            this.tbUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUtilisateur.Location = new System.Drawing.Point(217, 167);
            this.tbUtilisateur.Name = "tbUtilisateur";
            this.tbUtilisateur.Size = new System.Drawing.Size(241, 30);
            this.tbUtilisateur.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Utilisateur";
            // 
            // btModifier
            // 
            this.btModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifier.Location = new System.Drawing.Point(190, 238);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(153, 68);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateNorme.Location = new System.Drawing.Point(217, 106);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.Size = new System.Drawing.Size(241, 30);
            this.tbDateNorme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de la norme";
            // 
            // tbNorme
            // 
            this.tbNorme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNorme.Location = new System.Drawing.Point(217, 47);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(241, 30);
            this.tbNorme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Norme";
            // 
            // frmMAJEtapeNormee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1135, 675);
            this.Controls.Add(this.gbEtapeNormee);
            this.Controls.Add(this.lvEtapeNormee);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmMAJEtapeNormee";
            this.Text = "frmMAJEtapeNormee";
            this.Load += new System.EventHandler(this.frmMAJEtapeNormee_Load);
            this.gbEtapeNormee.ResumeLayout(false);
            this.gbEtapeNormee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEtapeNormee;
        private System.Windows.Forms.GroupBox gbEtapeNormee;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox tbDateNorme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNorme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox tbUtilisateur;
        private System.Windows.Forms.Label label3;
    }
}