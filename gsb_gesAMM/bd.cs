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
    }
}
