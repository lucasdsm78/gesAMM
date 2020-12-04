using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class bd
    {
        public static Boolean verifConnexion(string username, string password)
        {
            SqlCommand maRequete = new SqlCommand("prc_verifConnexion", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter paramUsername = new SqlParameter("@usr_username", System.Data.SqlDbType.Int, 30);
            paramUsername.Value = username;
            SqlParameter paramPassword = new SqlParameter("@usr_password", System.Data.SqlDbType.Char, 30);
            paramPassword.Value = password;
            maRequete.Parameters.Add(paramUsername);
            maRequete.Parameters.Add(paramPassword);
            
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<WorkFlow> addWorkFlow()
        {
            List<WorkFlow> laListe = new List<WorkFlow>();

            SqlCommand maRequete = new SqlCommand("prc_workflow_liste", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = maRequete.ExecuteReader();

            while (sqlDataReader.Read())
            {
                DateTime laDate = DateTime.Parse(sqlDataReader["wkf_date_decision"].ToString());
                int numEtape = int.Parse(sqlDataReader["wkf_etp_id"].ToString());
                int numDecision = int.Parse(sqlDataReader["wkf_dcs_id"].ToString());
                string codeMed = sqlDataReader["wkf_med_id"].ToString();

                laListe.Add(new WorkFlow(laDate, numEtape, numDecision, codeMed));
            }

            return laListe;
        }
    }
}
