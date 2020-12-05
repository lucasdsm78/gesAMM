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

        private void frmWorkFlowMed_Load(object sender, EventArgs e)
        {

            DataTable maTableDocument = new DataTable();
            maTableDocument.Columns.Add("ref");
            maTableDocument.Columns.Add("titre");

            foreach (string laRef in Globale.lesMedicaments.Keys)
            {
                maTableDocument.Rows.Add(laRef, Globale.lesMedicaments[laRef].getMedNomCommercial());
            }

            cbMed.DataSource = maTableDocument;
            cbMed.ValueMember = "ref";
            cbMed.DisplayMember = "titre";
        }

        private void cbMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string laRefMed in Globale.lesMedicaments.Keys)
            {
                Medicament unMedicament = Globale.lesMedicaments[laRefMed];

                if (unMedicament.getMedDepotLegal() == cbMed.SelectedIndex.ToString())
                {
                    foreach (WorkFlow unWorkFlow in unMedicament.getLesEtapes())
                    {
                        int idxEtape = 0;
                        int idxDecission = 0;

                        Boolean trouveEtape = false;
                        Boolean trouveDecision = false;

                        Etape monEtape = null;
                        Decision maDecision = null;

                        while (idxEtape < Globale.lesEtapes.Count)
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

                        while (idxDecission < Globale.lesDecisions.Count)
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
                            ligne.SubItems.Add(unWorkFlow.getWkfDateDecision().ToString());
                            ligne.SubItems.Add(maDecision.getDcsLibelle());
                            ligne.SubItems.Add(monEtape.getEtpNorme());
                            ligne.SubItems.Add(monEtape.getEtpDateNorme().ToString());
                        }
                    }
                }
            }
        }
    }
}
