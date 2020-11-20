using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class Famille
    {
        private string fam_code;
        private string fam_libelle;
        private int fam_nbMediAmm;

        public Famille(string leFamCode, string leFamLibelle, int leFamNbMediAmm)
        {
            this.fam_code = leFamCode;
            this.fam_libelle = leFamLibelle;
            this.fam_nbMediAmm = leFamNbMediAmm;
        }

        public string getFamCode() { return this.fam_code; }
        public string getFamLibelle() { return this.fam_libelle; }
        public int getFamNbMediAmm() { return this.fam_nbMediAmm; }

    }
}
