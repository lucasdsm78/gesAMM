using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class Medicament
    {
        private string med_depotlegal;
        private string med_nomCommercial;
        private string med_Composition;
        private string med_effets;
        private string med_contreindication;
        private string med_amm;
        private int med_derniereEtape;
        private string med_CodeFamille;
        private List<WorkFlow> lesEtapes;


        public Medicament(string leMedDepotLegal, string leMedNomCommercial, string leMedComposition, string leMedEffets, string leMedContreIndications, string leMedAmm, int leMedDerniereEtape, string leMedCodeFamille)
        {
            this.med_depotlegal = leMedDepotLegal;
            this.med_nomCommercial = leMedNomCommercial;
            this.med_Composition = leMedComposition;
            this.med_effets = leMedEffets;
            this.med_contreindication = leMedContreIndications;
            this.med_amm = leMedAmm;
            this.med_derniereEtape = leMedDerniereEtape;
            this.med_CodeFamille = leMedCodeFamille;
            this.lesEtapes = new List<WorkFlow>();
        }

        public string getMedDepotLegal() { return this.med_depotlegal; }
        public string getMedNomCommercial() { return this.med_nomCommercial; }
        public string getMedComposition() { return this.med_Composition; }
        public string getMedEffets() { return this.med_effets; }
        public string getMedContreIndications() { return this.med_contreindication; }
        public string getMedAmm() { return this.med_amm; }
        public int getMedDerniereEtape() { return this.med_derniereEtape; }
        public string getMedCodeFamille() { return this.med_CodeFamille; }

        public List<WorkFlow> getLesEtapes() { return this.lesEtapes; }

        public void ajouterWorkflow(WorkFlow leWorkflow)
        {
            this.lesEtapes.Add(leWorkflow);
        }
    }
}
