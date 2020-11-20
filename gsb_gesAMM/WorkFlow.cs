using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class WorkFlow
    {
        private DateTime wkf_date_decision;
        private int wkf_etp_num;
        private int wkf_dcs_id;
        private string wkf_med_Id;

        public WorkFlow(DateTime leWkfDatDecision, int leWkfEtpNum, int leWkdDcsId, string leWkfMedDl)
        {
            this.wkf_date_decision = leWkfDatDecision;
            this.wkf_etp_num = leWkfEtpNum;
            this.wkf_dcs_id = leWkdDcsId;
            this.wkf_med_Id = leWkfMedDl;
        }

        public DateTime getWkfDateDecision() { return this.wkf_date_decision; }
        public int getWkfEtpNum() { return this.wkf_etp_num; }
        public int getWkfDcsId() { return this.wkf_dcs_id; }
        public string getWkfMedId() { return this.wkf_med_Id; }
    }
}
