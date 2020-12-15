using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_gesAMM
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            Globale.connect();

            tbLogin.Text = "Admin";
            tbMdp.Text = "Admin123";
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text == "" && tbMdp.Text == "")
            {
                MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bd.verifConnexion(tbLogin.Text, tbMdp.Text))
                {
                    frmMenu open = new frmMenu();
                    open.Show();
                }
                else
                {
                    MessageBox.Show("Identitée introuvable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
