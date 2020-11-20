using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class Decision
    {
        private int dcs_id;
        private string dcs_libelle;

        public Decision(int leDcsId, string leDcsLibelle)
        {
            this.dcs_id = leDcsId;
            this.dcs_libelle = leDcsLibelle;
        }

        public int getDcsId() { return this.dcs_id; }
        public string getDcsLibelle() { return this.dcs_libelle; }
    }
}
