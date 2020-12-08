﻿using System;
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
        }
    }
}
