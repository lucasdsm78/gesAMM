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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDateDecision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.tbTypeDecision = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDerniereEtape.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Libelle";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date de la norme";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(137, 49);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(100, 22);
            this.tbNumero.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(137, 100);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 10;
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(137, 146);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.ReadOnly = true;
            this.tbLibelle.Size = new System.Drawing.Size(100, 22);
            this.tbLibelle.TabIndex = 11;
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(137, 197);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.ReadOnly = true;
            this.tbNorme.Size = new System.Drawing.Size(100, 22);
            this.tbNorme.TabIndex = 12;
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Location = new System.Drawing.Point(137, 242);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.ReadOnly = true;
            this.tbDateNorme.Size = new System.Drawing.Size(100, 22);
            this.tbDateNorme.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbTypeDecision);
            this.groupBox1.Controls.Add(this.tbDateDecision);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(585, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 185);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prochaine Etape";
            // 
            // tbDateDecision
            // 
            this.tbDateDecision.Location = new System.Drawing.Point(138, 49);
            this.tbDateDecision.Name = "tbDateDecision";
            this.tbDateDecision.Size = new System.Drawing.Size(100, 22);
            this.tbDateDecision.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 52);
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
            // tbTypeDecision
            // 
            this.tbTypeDecision.Location = new System.Drawing.Point(138, 94);
            this.tbTypeDecision.Name = "tbTypeDecision";
            this.tbTypeDecision.Size = new System.Drawing.Size(100, 22);
            this.tbTypeDecision.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Type décision";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 64);
            this.button1.TabIndex = 16;
            this.button1.Text = "Valider la décision";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSaisieDecisionEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDerniereEtape);
            this.Controls.Add(this.cbMedicament);
            this.Controls.Add(this.label1);
            this.Name = "frmSaisieDecisionEtape";
            this.Text = "frmSaisieDecisionEtape";
            this.Load += new System.EventHandler(this.frmSaisieDecisionEtape_Load);
            this.gbDerniereEtape.ResumeLayout(false);
            this.gbDerniereEtape.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTypeDecision;
        private System.Windows.Forms.TextBox tbDateDecision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button button1;
    }
}