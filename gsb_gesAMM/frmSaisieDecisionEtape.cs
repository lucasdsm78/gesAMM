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
            int decisionId = 0;
            int etpNum = 0;
            string medId = "";
            DateTime max = DateTime.MinValue;
            string depotlegalchoisi = cbMedicament.Text;
            foreach (string laReference in Globale.lesMedicaments.Keys)
            {
                Medicament unMedicament = Globale.lesMedicaments[laReference];
                foreach (WorkFlow leWorkflow in unMedicament.getLesEtapes())
                {
                    if (leWorkflow.getWkfMedId() == depotlegalchoisi)
                    {
                        if (leWorkflow.getWkfDateDecision() > max)
                        {
                            max = leWorkflow.getWkfDateDecision();
                            decisionId = leWorkflow.getWkfDcsId();
                            etpNum = leWorkflow.getWkfEtpNum();
                            medId = leWorkflow.getWkfMedId();
                        }
                    }
                }
            }
            if (decisionId == 1)
            {
                MessageBox.Show("la dernière étape est acceptée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbDerniereEtape.Visible = true;
                gbProchaineEtape.Visible = true;
                btValidDecision.Visible = true;

                foreach (Etape uneEtape in Globale.lesEtapes)
                {
                    if (uneEtape.getEtpNum() == etpNum)
                    {
                        tbDate.Text = max.ToShortDateString();
                        tbDateNorme.Text = uneEtape.getEtpDateNorme().ToShortDateString();
                        tbLibelle.Text = uneEtape.getEtpLibelle();
                        tbNorme.Text = uneEtape.getEtpNorme();
                        tbNumero.Text = etpNum.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("La dernière étape est refusée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int wkfEtpNum = 0;
            int wkfDcsId = 0;
            foreach (Decision uneDecision in Globale.lesDecisions)
            {
                if(uneDecision.getDcsLibelle() == tbTypeDecision.Text)
                {
                    wkfDcsId = uneDecision.getDcsId();
                }
            }

            if (tbDateDecision.Text == "" || tbTypeDecision.Text == "")
            {
                MessageBox.Show("Informations manquantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(wkfDcsId == 0)
                {
                    MessageBox.Show("Décision inexistante", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (bd.ajouterWorkflow(DateTime.Parse(tbDateDecision.Text), wkfEtpNum, wkfDcsId, depotlegalchoisi))
                    {
                        MessageBox.Show("la nouvelle étape a bien été ajoutée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans l'ajout du workflow", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
