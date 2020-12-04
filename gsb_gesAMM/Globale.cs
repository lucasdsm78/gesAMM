using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class Globale
    {
        public static SqlConnection cnx;

        public static Dictionary<string, Famille> lesFamilles;
        public static Dictionary<string, Medicament> lesMedicaments;

        public static List<Utilisateur> lesUtilisateurs;
        public static List<Decision> lesDecisions;
        public static List<Etape> lesEtapes;

        public static void connect()
        {
             Globale.cnx = new System.Data.SqlClient.SqlConnection();
             Globale.cnx.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
             Globale.cnx.Open();
        }
    }
}
