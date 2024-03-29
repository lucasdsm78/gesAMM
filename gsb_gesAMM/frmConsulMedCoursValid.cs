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
                    ligne.Text = unMed.getMedDepotLegal();
                    ligne.SubItems.Add(unMed.getMedNomCommercial());
                    ligne.SubItems.Add(libFam);
                    lvMeds.Items.Add(ligne);
                }
            }
        }

        private void lvMeds_Click(object sender, EventArgs e)
        {
            lvMedsWorkflow.Items.Clear();
            Medicament unMeds = Globale.lesMedicaments[lvMeds.SelectedItems[0].Text];
            foreach(WorkFlow unWorkflow in unMeds.getLesEtapes())
            {
                ListViewItem ligne2 = new ListViewItem();
                ligne2.Text = unWorkflow.getWkfEtpNum().ToString();
                foreach(Decision uneDecision in Globale.lesDecisions)
                {
                    if(unWorkflow.getWkfDcsId() == uneDecision.getDcsId())
                    {
                        ligne2.SubItems.Add(uneDecision.getDcsLibelle());
                    }
                    
                }
                //ligne2.SubItems.Add(unWorkflow.getWkfDcsId().ToString());
                ligne2.SubItems.Add(unWorkflow.getWkfDateDecision().ToString());
                lvMedsWorkflow.Items.Add(ligne2);
            }
        }
    }
}
