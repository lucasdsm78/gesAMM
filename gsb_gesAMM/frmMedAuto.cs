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
    public partial class frmMedAuto : Form
    {
        public frmMedAuto()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMedAuto_Load(object sender, EventArgs e)
        {
            changerListe = false;

            lvListMed.Items.Clear();

            foreach (string uneFamille in Globale.lesFamilles.Keys)
            {
                int nbMedicament = 0;

                Famille laFamille = Globale.lesFamilles[uneFamille];

                foreach (string codeDepot in Globale.lesMedicaments.Keys)
                {
                    Medicament leMedicament = Globale.lesMedicaments[codeDepot];

                    if (laFamille.getFamCode() == leMedicament.getMedCodeFamille())
                    {
                        nbMedicament++;
                    }
                }

                ListViewItem ligne = new ListViewItem();
                ligne.Text = laFamille.getFamCode();
                ligne.SubItems.Add(laFamille.getFamLibelle());
                ligne.SubItems.Add(nbMedicament.ToString());

                lvListMed.Items.Add(ligne);
            }

            changerListe = true;
        }

        Boolean changerListe;

        private void lvListMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changerListe == true && lvListMed.SelectedItems.Count > 0)
            {
                lvListMedAuto.Items.Clear();

                foreach (string leDepotLegal in Globale.lesMedicaments.Keys)
                {
                    Medicament unMedicament = Globale.lesMedicaments[leDepotLegal];

                    if (unMedicament.getMedCodeFamille() == lvListMed.SelectedItems[0].Text)
                    {
                        ListViewItem ligne = new ListViewItem();
                        ligne.Text = unMedicament.getMedDepotLegal();
                        ligne.SubItems.Add(unMedicament.getMedNomCommercial());
                        ligne.SubItems.Add(unMedicament.getMedComposition());
                        ligne.SubItems.Add(unMedicament.getMedEffets());
                        ligne.SubItems.Add(unMedicament.getMedContreIndications());
                        ligne.SubItems.Add(unMedicament.getMedAmm());

                        lvListMedAuto.Items.Add(ligne);
                    }
                }
            }
        }
    }
}
