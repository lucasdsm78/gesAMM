namespace gsb_gesAMM
{
    partial class frmSaisieDecisionEtape
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.gbDerniereEtape = new System.Windows.Forms.GroupBox();
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbDateNorme = new System.Windows.Forms.Label();
            this.lbNorme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProchaineEtape = new System.Windows.Forms.GroupBox();
            this.tbMedicament = new System.Windows.Forms.TextBox();
            this.tbEtape = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDateDecision = new System.Windows.Forms.DateTimePicker();
            this.rbRefusee = new System.Windows.Forms.RadioButton();
            this.rbValidée = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btValidDecision = new System.Windows.Forms.Button();
            this.gbDerniereEtape.SuspendLayout();
            this.gbProchaineEtape.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicament";
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(245, 73);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(121, 24);
            this.cbMedicament.TabIndex = 1;
            // 
            // gbDerniereEtape
            // 
            this.gbDerniereEtape.Controls.Add(this.tbDateNorme);
            this.gbDerniereEtape.Controls.Add(this.tbNorme);
            this.gbDerniereEtape.Controls.Add(this.tbLibelle);
            this.gbDerniereEtape.Controls.Add(this.tbDate);
            this.gbDerniereEtape.Controls.Add(this.tbNumero);
            this.gbDerniereEtape.Controls.Add(this.lbDateNorme);
            this.gbDerniereEtape.Controls.Add(this.lbNorme);
            this.gbDerniereEtape.Controls.Add(this.label4);
            this.gbDerniereEtape.Controls.Add(this.label3);
            this.gbDerniereEtape.Controls.Add(this.label2);
            this.gbDerniereEtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDerniereEtape.Location = new System.Drawing.Point(99, 154);
            this.gbDerniereEtape.Name = "gbDerniereEtape";
            this.gbDerniereEtape.Size = new System.Drawing.Size(416, 284);
            this.gbDerniereEtape.TabIndex = 2;
            this.gbDerniereEtape.TabStop = false;
            this.gbDerniereEtape.Text = "Dernière Etape";
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Location = new System.Drawing.Point(192, 245);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.ReadOnly = true;
            this.tbDateNorme.Size = new System.Drawing.Size(100, 30);
            this.tbDateNorme.TabIndex = 13;
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(137, 197);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.ReadOnly = true;
            this.tbNorme.Size = new System.Drawing.Size(100, 30);
            this.tbNorme.TabIndex = 12;
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(137, 146);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.ReadOnly = true;
            this.tbLibelle.Size = new System.Drawing.Size(100, 30);
            this.tbLibelle.TabIndex = 11;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(128, 100);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(100, 30);
            this.tbDate.TabIndex = 10;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(128, 46);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(100, 30);
            this.tbNumero.TabIndex = 5;
            // 
            // lbDateNorme
            // 
            this.lbDateNorme.AutoSize = true;
            this.lbDateNorme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateNorme.Location = new System.Drawing.Point(10, 245);
            this.lbDateNorme.Name = "lbDateNorme";
            this.lbDateNorme.Size = new System.Drawing.Size(176, 25);
            this.lbDateNorme.TabIndex = 4;
            this.lbDateNorme.Text = "Date de la norme";
            // 
            // lbNorme
            // 
            this.lbNorme.AutoSize = true;
            this.lbNorme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNorme.Location = new System.Drawing.Point(7, 197);
            this.lbNorme.Name = "lbNorme";
            this.lbNorme.Size = new System.Drawing.Size(75, 25);
            this.lbNorme.TabIndex = 3;
            this.lbNorme.Text = "Norme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero";
            // 
            // gbProchaineEtape
            // 
            this.gbProchaineEtape.Controls.Add(this.tbMedicament);
            this.gbProchaineEtape.Controls.Add(this.tbEtape);
            this.gbProchaineEtape.Controls.Add(this.label8);
            this.gbProchaineEtape.Controls.Add(this.label9);
            this.gbProchaineEtape.Controls.Add(this.dtDateDecision);
            this.gbProchaineEtape.Controls.Add(this.rbRefusee);
            this.gbProchaineEtape.Controls.Add(this.rbValidée);
            this.gbProchaineEtape.Controls.Add(this.label10);
            this.gbProchaineEtape.Controls.Add(this.label7);
            this.gbProchaineEtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProchaineEtape.Location = new System.Drawing.Point(585, 154);
            this.gbProchaineEtape.Name = "gbProchaineEtape";
            this.gbProchaineEtape.Size = new System.Drawing.Size(460, 291);
            this.gbProchaineEtape.TabIndex = 14;
            this.gbProchaineEtape.TabStop = false;
            this.gbProchaineEtape.Text = "Prochaine Etape";
            // 
            // tbMedicament
            // 
            this.tbMedicament.Location = new System.Drawing.Point(143, 95);
            this.tbMedicament.Name = "tbMedicament";
            this.tbMedicament.ReadOnly = true;
            this.tbMedicament.Size = new System.Drawing.Size(100, 30);
            this.tbMedicament.TabIndex = 15;
            // 
            // tbEtape
            // 
            this.tbEtape.Location = new System.Drawing.Point(143, 149);
            this.tbEtape.Name = "tbEtape";
            this.tbEtape.ReadOnly = true;
            this.tbEtape.Size = new System.Drawing.Size(100, 30);
            this.tbEtape.TabIndex = 17;
            this.tbEtape.TextChanged += new System.EventHandler(this.tbEtape_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Médicament";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Etape";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtDateDecision
            // 
            this.dtDateDecision.Location = new System.Drawing.Point(197, 44);
            this.dtDateDecision.Name = "dtDateDecision";
            this.dtDateDecision.Size = new System.Drawing.Size(253, 30);
            this.dtDateDecision.TabIndex = 18;
            // 
            // rbRefusee
            // 
            this.rbRefusee.AutoSize = true;
            this.rbRefusee.Location = new System.Drawing.Point(176, 228);
            this.rbRefusee.Name = "rbRefusee";
            this.rbRefusee.Size = new System.Drawing.Size(112, 29);
            this.rbRefusee.TabIndex = 17;
            this.rbRefusee.TabStop = true;
            this.rbRefusee.Text = "Refusée";
            this.rbRefusee.UseVisualStyleBackColor = true;
            // 
            // rbValidée
            // 
            this.rbValidée.AutoSize = true;
            this.rbValidée.Location = new System.Drawing.Point(46, 228);
            this.rbValidée.Name = "rbValidée";
            this.rbValidée.Size = new System.Drawing.Size(124, 29);
            this.rbValidée.TabIndex = 16;
            this.rbValidée.TabStop = true;
            this.rbValidée.Text = "Acceptée";
            this.rbValidée.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(106, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Type décision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date de la décision";
            // 
            // btValider
            // 
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(405, 43);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(214, 77);
            this.btValider.TabIndex = 15;
            this.btValider.Text = "Valider le médicament";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btValidDecision
            // 
            this.btValidDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValidDecision.Location = new System.Drawing.Point(653, 478);
            this.btValidDecision.Name = "btValidDecision";
            this.btValidDecision.Size = new System.Drawing.Size(156, 64);
            this.btValidDecision.TabIndex = 16;
            this.btValidDecision.Text = "Valider la décision";
            this.btValidDecision.UseVisualStyleBackColor = true;
            this.btValidDecision.Click += new System.EventHandler(this.btValidDecision_Click);
            // 
            // frmSaisieDecisionEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btValidDecision);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.gbProchaineEtape);
            this.Controls.Add(this.gbDerniereEtape);
            this.Controls.Add(this.cbMedicament);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmSaisieDecisionEtape";
            this.Text = "Saisir une date de décision d\'une étape";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSaisieDecisionEtape_Load);
            this.gbDerniereEtape.ResumeLayout(false);
            this.gbDerniereEtape.PerformLayout();
            this.gbProchaineEtape.ResumeLayout(false);
            this.gbProchaineEtape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.GroupBox gbDerniereEtape;
        private System.Windows.Forms.TextBox tbDateNorme;
        private System.Windows.Forms.TextBox tbNorme;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbDateNorme;
        private System.Windows.Forms.Label lbNorme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProchaineEtape;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btValidDecision;
        private System.Windows.Forms.TextBox tbMedicament;
        private System.Windows.Forms.TextBox tbEtape;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtDateDecision;
        private System.Windows.Forms.RadioButton rbRefusee;
        private System.Windows.Forms.RadioButton rbValidée;
    }
}