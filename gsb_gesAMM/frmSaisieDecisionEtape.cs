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
    public partial class frmSaisieDecisionEtape : Form
    {
        public frmSaisieDecisionEtape()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            List<DateTime> lesDatesDuDepotLegal = new List<DateTime>();
            Boolean decision = false;
            string depotlegalchoisi = cbMedicament.Text;

            WorkFlow leWorkflow = bd.lireDerniereEtapeNormee(depotlegalchoisi);


            if (leWorkflow.getWkfDcsId() == 1 && leWorkflow.getWkfEtpNum() != 8)
            {
                MessageBox.Show("la dernière étape est acceptée et l'étape suivante est disponible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbDerniereEtape.Visible = true;
                gbProchaineEtape.Visible = true;
                btValidDecision.Visible = true;

                tbNumero.Text = leWorkflow.getWkfEtpNum().ToString();
                tbDate.Text = leWorkflow.getWkfDateDecision().ToShortDateString();
                tbLibelle.Text = Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1).getEtpLibelle();

                /* foreach (Etape uneEtape in Globale.lesEtapes)
                 {*/
                if (Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1).GetType().Name == "EtapeNormee")
                {
                    tbNorme.Text = (Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1) as EtapeNormee).getEtpNorme();
                    tbDateNorme.Text = (Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1) as EtapeNormee).getEtpDateNorme().ToShortDateString();                       
                }
                else
                {
                    tbNorme.Visible = false;
                    tbDateNorme.Visible = false;
                    lbDateNorme.Visible = false;
                    lbNorme.Visible = false;
                }
                

                tbMedicament.Text = depotlegalchoisi;
                int wkfEtpNum = int.Parse(tbNumero.Text) + 1;
                tbEtape.Text = wkfEtpNum.ToString();
            }

            else
            {
                if (leWorkflow.getWkfDcsId() == 1 && leWorkflow.getWkfEtpNum() == 8)
                {
                    MessageBox.Show("la dernière étape est acceptée mais l'étape suivante est indisponible car il n'y a plus d'étapes suivantes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gbDerniereEtape.Visible = true;
                    gbProchaineEtape.Visible = true;
                    btValidDecision.Visible = true;

                    tbNumero.Text = leWorkflow.getWkfEtpNum().ToString();
                    tbDate.Text = leWorkflow.getWkfDateDecision().ToShortDateString();

                    tbLibelle.Text = Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1).getEtpLibelle();

                    /* foreach (Etape uneEtape in Globale.lesEtapes)
                     {*/

                    if (Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1).GetType().Name == "EtapeNormee")
                    {
                        tbNorme.Text = (Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1) as EtapeNormee).getEtpNorme();
                        tbDateNorme.Text = (Globale.lesEtapes.ElementAt(leWorkflow.getWkfEtpNum() - 1) as EtapeNormee).getEtpDateNorme().ToShortDateString();
                    }
                    else
                    {
                        tbNorme.Visible = false;
                        tbDateNorme.Visible = false;
                        lbDateNorme.Visible = false;
                        lbNorme.Visible = false;
                    }

                    tbMedicament.Text = "Etape suivante indisponible";
                    tbEtape.Text = "Etape suivante indisponible";
                    dtDateDecision.Enabled = false;
                    rbRefusee.Enabled = false;
                    rbValidée.Enabled = false;
                    btValidDecision.Enabled = false;
                }
                else
                {
                    MessageBox.Show("la dernière étape est refusée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



        private void chargerListeMedicament()
        {
            bd.lireLesMedicaments();

            foreach (string depotlegal in Globale.lesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.lesMedicaments[depotlegal];
                cbMedicament.Items.Add(leMedicament.getMedDepotLegal());
            }
        }

        private void frmSaisieDecisionEtape_Load(object sender, EventArgs e)
        {
            chargerListeMedicament();

            gbDerniereEtape.Visible = false;
            gbProchaineEtape.Visible = false;
            btValidDecision.Visible = false;
        }

        private void btValidDecision_Click(object sender, EventArgs e)
        {
            string depotlegalchoisi = cbMedicament.Text;
            int wkfDcsId = 0;
            if (rbRefusee.Checked)
            {
                wkfDcsId = 2;
            }
            else
            {
                wkfDcsId = 1;
            }


            if (bd.ajouterWorkflow(dtDateDecision.Value, int.Parse(tbEtape.Text), wkfDcsId, tbMedicament.Text))
            {
                MessageBox.Show("la nouvelle étape a bien été ajoutée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur dans l'ajout du workflow", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbEtape_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

