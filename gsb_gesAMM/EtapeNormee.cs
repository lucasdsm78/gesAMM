using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class EtapeNormee : Etape
    {
        string etp_norme;
        DateTime etp_date_norme;
        int etp_user;

        public EtapeNormee(int leEtpNum, string leEtpLibelle, string laEtpNorme, DateTime laEtpDateNorme, int leEtpUser) : base(leEtpNum, leEtpLibelle)
        {
            this.etp_norme = laEtpNorme;
            this.etp_date_norme = laEtpDateNorme;
            this.etp_user = leEtpUser;
        }

        public string getEtpNorme() { return this.etp_norme; }
        public DateTime getEtpDateNorme() { return this.etp_date_norme; }
        public int getEtpUser() { return this.etp_user; }
    }
}
