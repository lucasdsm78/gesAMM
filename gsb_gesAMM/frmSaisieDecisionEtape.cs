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

            if (leWorkflow.getWkfDcsId() == 1)
            {
                MessageBox.Show("la dernière étape est acceptée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbDerniereEtape.Visible = true;
                gbProchaineEtape.Visible = true;
                btValidDecision.Visible = true;

                tbNumero.Text = leWorkflow.getWkfEtpNum().ToString();
                tbDate.Text = leWorkflow.getWkfDateDecision().ToShortDateString();

                foreach (Etape uneEtape in Globale.lesEtapes)
                {
                    tbLibelle.Text = uneEtape.getEtpLibelle();
                    if (uneEtape.GetType().Name == "EtapeNormee")
                    {
                        if (uneEtape.getEtpNum() == leWorkflow.getWkfEtpNum())
                        {
                            tbNorme.Text = (uneEtape as EtapeNormee).getEtpNorme();
                            tbDateNorme.Text = (uneEtape as EtapeNormee).getEtpDateNorme().ToShortDateString();
                        }
                    }
                    else
                    {
                        tbNorme.Visible = false;
                        tbDateNorme.Visible = false;
                    }
                }

                tbMedicament.Text = depotlegalchoisi;
                int wkfEtpNum = int.Parse(tbNumero.Text) + 1;
                tbEtape.Text = wkfEtpNum.ToString();
            }


            /*foreach (Etape uneEtape in Globale.lesEtapes)
            {
                if (uneEtape.getEtpNum() == etpNum)
                {
                    tbDate.Text = max.ToShortDateString();
                    tbDateNorme.Text = uneEtape.getEtpDateNorme().ToShortDateString();
                    tbLibelle.Text = uneEtape.getEtpLibelle();
                    tbNorme.Text = uneEtape.getEtpNorme();
                    tbNumero.Text = etpNum.ToString();
                }
            }*/

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
