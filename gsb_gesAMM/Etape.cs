using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class Etape
    {
        private int etp_num;
        private string etp_libelle;

        public Etape(int leEtpNum, string leEtpLibelle)
        {
            this.etp_num = leEtpNum;
            this.etp_libelle = leEtpLibelle;
        }

        public int getEtpNum() { return this.etp_num; }
        public string getEtpLibelle() { return this.etp_libelle; }

    }
}
