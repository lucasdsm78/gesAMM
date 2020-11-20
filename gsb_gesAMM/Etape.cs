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
        private string etp_norme;
        private DateTime etp_date_norme;

        public Etape(int leEtpNum, string leEtpLibelle, string leEtpNorme, DateTime leEtpDateNorme)
        {
            this.etp_num = leEtpNum;
            this.etp_libelle = leEtpLibelle;
            this.etp_norme = leEtpNorme;
            this.etp_date_norme = leEtpDateNorme;
        }

        public int getEtpNum() { return this.etp_num; }
        public string getEtpNorme() { return this.etp_norme; }
        public string getEtpLibelle() { return this.etp_libelle; }
        public DateTime getEtpDateNorme() { return this.etp_date_norme; }

    }
}
