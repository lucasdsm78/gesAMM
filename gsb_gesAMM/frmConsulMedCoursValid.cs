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
    public partial class frmConsulMedCoursValid : Form
    {
        public frmConsulMedCoursValid()
        {
            InitializeComponent();
        }

        private void frmConsulMedCoursValid_Load(object sender, EventArgs e)
        {
            //Fonctionnalité incomplète car je ne vois pas a quoi ressemble le med_amm de Medicament
            string libFam = "";
            foreach(string leCode in Globale.lesMedicaments.Keys)
            {
                Medicament unMed = Globale.lesMedicaments[leCode];
                foreach(string unCode in Globale.lesFamilles.Keys)
                {
                    if(Globale.lesFamilles[unCode].getFamCode() == unMed.getMedCodeFamille())
                    {
                        libFam = Globale.lesFamilles[unCode].getFamLibelle();
                    }
                }
                if(unMed.getMedAmm() == "")
                {
                    ListViewItem ligne = new ListViewItem();
                    ligne.SubItems.Add(unMed.getMedDepotLegal());
                    ligne.SubItems.Add(unMed.getMedNomCommercial());
                    ligne.SubItems.Add(libFam);
                    lvMeds.Items.Add(ligne);
                }
            }
        }

        private void lvMeds_Click(object sender, EventArgs e)
        {
            Medicament unMeds = Globale.lesMedicaments[lvMeds.SelectedItems[0].Text];
            foreach(WorkFlow unWorkflow in unMeds.getLesEtapes())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.SubItems.Add(unWorkflow.getWkfEtpNum().ToString());
                ligne.SubItems.Add(unWorkflow.getWkfDcsId().ToString());
                ligne.SubItems.Add(unWorkflow.getWkfDateDecision().ToString());
                lvMedsWorkflow.Items.Add(ligne);
            }
        }
    }
}
