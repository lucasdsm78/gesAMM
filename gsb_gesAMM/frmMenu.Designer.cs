namespace gsb_gesAMM
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adherentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empruntToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.adherentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.retourToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.empruntToolStripMenuItem.Text = "Médicament";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(631, 34);
            this.nouveauToolStripMenuItem.Text = "Ajouter";
            // 
            // retourToolStripMenuItem
            // 
            this.retourToolStripMenuItem.Name = "retourToolStripMenuItem";
            this.retourToolStripMenuItem.Size = new System.Drawing.Size(631, 34);
            this.retourToolStripMenuItem.Text = "Consultation en cours de validation";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(631, 34);
            this.statistiquesToolStripMenuItem.Text = "Consultation du nombre de médicaments autorisés par la famille ";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(631, 34);
            this.quitterToolStripMenuItem.Text = "Quitter l\'application";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.papierToolStripMenuItem,
            this.numeriqueToolStripMenuItem});
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.documentToolStripMenuItem.Text = "Etape";
            // 
            // papierToolStripMenuItem
            // 
            this.papierToolStripMenuItem.Name = "papierToolStripMenuItem";
            this.papierToolStripMenuItem.Size = new System.Drawing.Size(369, 34);
            this.papierToolStripMenuItem.Text = "Saisie de la décision d\'une étape";
            // 
            // numeriqueToolStripMenuItem
            // 
            this.numeriqueToolStripMenuItem.Name = "numeriqueToolStripMenuItem";
            this.numeriqueToolStripMenuItem.Size = new System.Drawing.Size(369, 34);
            this.numeriqueToolStripMenuItem.Text = "Mise à jour des étapes normées";
            // 
            // adherentToolStripMenuItem
            // 
            this.adherentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem1});
            this.adherentToolStripMenuItem.Name = "adherentToolStripMenuItem";
            this.adherentToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.adherentToolStripMenuItem.Text = "Workflow";
            // 
            // listeToolStripMenuItem1
            // 
            this.listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            this.listeToolStripMenuItem1.Size = new System.Drawing.Size(551, 34);
            this.listeToolStripMenuItem1.Text = "Consultation du workflow des étapes d\'un médicament";
            this.listeToolStripMenuItem1.Click += new System.EventHandler(this.listeToolStripMenuItem1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 814);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de l\'application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeriqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adherentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem1;
    }
}