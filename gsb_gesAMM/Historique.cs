using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class Historique
    {
        private int htq_id;
        private int htq_user;
        private int htq_etp_num;
        private DateTime htq_date_maj;
        private DateTime htq_date_old;
        private DateTime htq_date_new;
        private string htq_norme_old;
        private string htq_norme_new;


        public Historique(int leHtqId, int leHtqtUser, int leHtqEtpNum, DateTime leHtqDateMaj, DateTime leHtqDateNew, DateTime leHtqDateOld, string leHtqNormeOld, string leHtqNormeNew)
        {
            this.htq_id = leHtqId;
            this.htq_user = leHtqtUser;
            this.htq_etp_num = leHtqEtpNum;
            this.htq_date_maj = leHtqDateMaj;
            this.htq_date_old = leHtqDateOld;
            this.htq_date_new = leHtqDateNew;
            this.htq_norme_old = leHtqNormeOld;
            this.htq_norme_new = leHtqNormeNew;
        }

        public int getHtqId() { return this.htq_id; }
        public int getHtqUser() { return this.htq_user; }
        public int getHtqEtpNum() { return this.htq_etp_num; }
        public DateTime getHtqDateMaj() { return this.htq_date_maj; }
        public DateTime getHtqDateNew() { return this.htq_date_new; }
        public DateTime getHtqDateOld() { return this.htq_date_old; }
        public string getHtqNormeOld() { return this.htq_norme_old; }
        public string getHtqNormeNew() { return this.htq_norme_new; }

    }
}
