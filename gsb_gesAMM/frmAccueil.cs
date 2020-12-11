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
            Globale.lesEtapes = new List<Etape>();
            Globale.lesDecisions = new List<Decision>();
            Globale.lesFamilles = new Dictionary<string, Famille>();
            Globale.lesMedicaments = new Dictionary<string, Medicament>();
            Globale.lesUtilisateurs = new List<Utilisateur>();

            /*bd.lireLesEtapes();
            bd.lireLesDecisions();
            bd.lireLesFamilles();
            bd.lireLesMedicaments();
            bd.lireLesUtilisateurs();*/
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text == "" && tbMdp.Text == "")
            {
                MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbLogin.Text == "lucas" && tbMdp.Text == "lucas")
                {
                    MessageBox.Show("Connexion réussie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
