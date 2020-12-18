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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProchaineEtape = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btValidDecision = new System.Windows.Forms.Button();
            this.rbValidée = new System.Windows.Forms.RadioButton();
            this.rbRefusee = new System.Windows.Forms.RadioButton();
            this.dtDateDecision = new System.Windows.Forms.DateTimePicker();
            this.tbMedicament = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEtape = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbDerniereEtape.SuspendLayout();
            this.gbProchaineEtape.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
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
            this.gbDerniereEtape.Controls.Add(this.label6);
            this.gbDerniereEtape.Controls.Add(this.label5);
            this.gbDerniereEtape.Controls.Add(this.label4);
            this.gbDerniereEtape.Controls.Add(this.label3);
            this.gbDerniereEtape.Controls.Add(this.label2);
            this.gbDerniereEtape.Location = new System.Drawing.Point(99, 154);
            this.gbDerniereEtape.Name = "gbDerniereEtape";
            this.gbDerniereEtape.Size = new System.Drawing.Size(416, 284);
            this.gbDerniereEtape.TabIndex = 2;
            this.gbDerniereEtape.TabStop = false;
            this.gbDerniereEtape.Text = "Dernière Etape";
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Location = new System.Drawing.Point(137, 242);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.ReadOnly = true;
            this.tbDateNorme.Size = new System.Drawing.Size(100, 22);
            this.tbDateNorme.TabIndex = 13;
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(137, 197);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.ReadOnly = true;
            this.tbNorme.Size = new System.Drawing.Size(100, 22);
            this.tbNorme.TabIndex = 12;
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(137, 146);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.ReadOnly = true;
            this.tbLibelle.Size = new System.Drawing.Size(100, 22);
            this.tbLibelle.TabIndex = 11;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(137, 100);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 10;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(137, 49);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(100, 22);
            this.tbNumero.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date de la norme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Norme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
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
            this.gbProchaineEtape.Location = new System.Drawing.Point(585, 154);
            this.gbProchaineEtape.Name = "gbProchaineEtape";
            this.gbProchaineEtape.Size = new System.Drawing.Size(403, 291);
            this.gbProchaineEtape.TabIndex = 14;
            this.gbProchaineEtape.TabStop = false;
            this.gbProchaineEtape.Text = "Prochaine Etape";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Type décision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date de la décision";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(405, 56);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(149, 56);
            this.btValider.TabIndex = 15;
            this.btValider.Text = "Valider le médicament";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btValidDecision
            // 
            this.btValidDecision.Location = new System.Drawing.Point(631, 478);
            this.btValidDecision.Name = "btValidDecision";
            this.btValidDecision.Size = new System.Drawing.Size(156, 64);
            this.btValidDecision.TabIndex = 16;
            this.btValidDecision.Text = "Valider la décision";
            this.btValidDecision.UseVisualStyleBackColor = true;
            this.btValidDecision.Click += new System.EventHandler(this.btValidDecision_Click);
            // 
            // rbValidée
            // 
            this.rbValidée.AutoSize = true;
            this.rbValidée.Location = new System.Drawing.Point(46, 228);
            this.rbValidée.Name = "rbValidée";
            this.rbValidée.Size = new System.Drawing.Size(88, 21);
            this.rbValidée.TabIndex = 16;
            this.rbValidée.TabStop = true;
            this.rbValidée.Text = "Acceptée";
            this.rbValidée.UseVisualStyleBackColor = true;
            // 
            // rbRefusee
            // 
            this.rbRefusee.AutoSize = true;
            this.rbRefusee.Location = new System.Drawing.Point(167, 228);
            this.rbRefusee.Name = "rbRefusee";
            this.rbRefusee.Size = new System.Drawing.Size(82, 21);
            this.rbRefusee.TabIndex = 17;
            this.rbRefusee.TabStop = true;
            this.rbRefusee.Text = "Refusée";
            this.rbRefusee.UseVisualStyleBackColor = true;
            // 
            // dtDateDecision
            // 
            this.dtDateDecision.Location = new System.Drawing.Point(135, 47);
            this.dtDateDecision.Name = "dtDateDecision";
            this.dtDateDecision.Size = new System.Drawing.Size(200, 22);
            this.dtDateDecision.TabIndex = 18;
            // 
            // tbMedicament
            // 
            this.tbMedicament.Location = new System.Drawing.Point(135, 95);
            this.tbMedicament.Name = "tbMedicament";
            this.tbMedicament.ReadOnly = true;
            this.tbMedicament.Size = new System.Drawing.Size(100, 22);
            this.tbMedicament.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Médicament";
            // 
            // tbEtape
            // 
            this.tbEtape.Location = new System.Drawing.Point(135, 146);
            this.tbEtape.Name = "tbEtape";
            this.tbEtape.ReadOnly = true;
            this.tbEtape.Size = new System.Drawing.Size(100, 22);
            this.tbEtape.TabIndex = 17;
            this.tbEtape.TextChanged += new System.EventHandler(this.tbEtape_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Etape";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSaisieDecisionEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btValidDecision);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.gbProchaineEtape);
            this.Controls.Add(this.gbDerniereEtape);
            this.Controls.Add(this.cbMedicament);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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