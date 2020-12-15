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
    public partial class frmNouvMed : Form
    {
        public frmNouvMed()
        {
            InitializeComponent();
        }

        private void frmNouvMed_Load(object sender, EventArgs e)
        {
            foreach(string leCode in Globale.lesFamilles.Keys)
            {
                cbFamille.Items.Add(Globale.lesFamilles[leCode].getFamLibelle());
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNouv_Click(object sender, EventArgs e)
        {
            tbDepot.Text = "";
            tbNomComm.Text = "";
            tbCompo.Text = "";
            tbEffets.Text = "";
            tbContreIndic.Text = "";
            cbFamille.Text = "";
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            //Fonctionnalité incomplète du au fait que je ne peux pas installer Sql server chez moi
            //Requête sql dans la classe bd inutilisable pour l'instant
            Boolean existe = false;
            string codeFam = "";
            foreach(string unCode in Globale.lesFamilles.Keys)
            {
                Famille uneFam = Globale.lesFamilles[unCode];
                if(uneFam.getFamLibelle() == cbFamille.Text)
                {
                    codeFam = uneFam.getFamCode();
                }
            }
            foreach(string leCode in Globale.lesMedicaments.Keys)
            {
                if(leCode == tbDepot.Text)
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            if(existe == true)
            {
                MessageBox.Show("Erreur, ce dépôt légal existe déjà");
            }
            else
            {
                bd.ajoutMedicament(tbDepot.Text, tbNomComm.Text, tbCompo.Text, tbEffets.Text, tbContreIndic.Text, codeFam);
                bd.lireLesMedicaments();
            }
        }
    }
}
