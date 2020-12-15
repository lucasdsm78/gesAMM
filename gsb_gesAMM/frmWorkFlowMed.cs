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
    public partial class frmWorkFlowMed : Form
    {
        public frmWorkFlowMed()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Boolean chargerListe;

        private void frmWorkFlowMed_Load(object sender, EventArgs e)
        {
            chargerListe = false;

            DataTable maTableDocument = new DataTable();
            maTableDocument.Columns.Add("ref");
            maTableDocument.Columns.Add("titre");

            maTableDocument.Rows.Add("", "CHOISIR UN MEDICAMENT");

            foreach (string laRef in Globale.lesMedicaments.Keys)
            {
                maTableDocument.Rows.Add(laRef, Globale.lesMedicaments[laRef].getMedNomCommercial());
            }

            cbMed.DataSource = maTableDocument;
            cbMed.ValueMember = "ref";
            cbMed.DisplayMember = "titre";

            chargerListe = true;
        }

        private void cbMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chargerListe == true)
            {
                lvMed.Items.Clear();

                foreach (string laRefMed in Globale.lesMedicaments.Keys)
                {
                    Medicament unMedicament = Globale.lesMedicaments[laRefMed];

                    if (unMedicament.getMedDepotLegal() == cbMed.SelectedValue.ToString())
                    {
                        foreach (WorkFlow unWorkFlow in unMedicament.getLesEtapes())
                        {
                            int idxEtape = 0;
                            int idxDecission = 0;

                            Boolean trouveEtape = false;
                            Boolean trouveDecision = false;

                            Etape monEtape = null;
                            Decision maDecision = null;

                            while (idxEtape < Globale.lesEtapes.Count && !trouveEtape)
                            {
                                Etape uneEtape = Globale.lesEtapes.ElementAt(idxEtape);

                                if (uneEtape.getEtpNum() == unWorkFlow.getWkfEtpNum())
                                {
                                    trouveEtape = true;
                                    monEtape = uneEtape;
                                }
                                else
                                {
                                    idxEtape++;
                                }
                            }

                            while (idxDecission < Globale.lesDecisions.Count && !trouveDecision)
                            {
                                Decision uneDecision = Globale.lesDecisions.ElementAt(idxDecission);

                                if (uneDecision.getDcsId() == unWorkFlow.getWkfDcsId())
                                {
                                    trouveDecision = true;
                                    maDecision = uneDecision;
                                }
                                else
                                {
                                    idxDecission++;
                                }
                            }

                            if (trouveEtape && trouveDecision)
                            {
                                ListViewItem ligne = new ListViewItem();
                                ligne.Text = monEtape.getEtpNum().ToString();
                                ligne.SubItems.Add(monEtape.getEtpLibelle());
                                ligne.SubItems.Add(unWorkFlow.getWkfDateDecision().ToString("dd/M/yyyy"));
                                ligne.SubItems.Add(maDecision.getDcsLibelle());
                                ligne.SubItems.Add("0");
                                ligne.SubItems.Add("0");

                                lvMed.Items.Add(ligne);
                            }
                        }
                    }
                }
            }
        }
    }
}
