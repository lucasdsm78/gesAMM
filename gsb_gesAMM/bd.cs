﻿using System;
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

        public static void lireLesMedicaments()
        {
            Globale.lesMedicaments.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeTousMedicaments", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string depotLegal = SqlExec["med_depotLegal"].ToString();
                string med_nomCommercial = SqlExec["med_nomCommercial"].ToString();
                string med_composition = SqlExec["med_composition"].ToString();
                string med_effets = SqlExec["med_effets"].ToString();
                string med_contreIndications = SqlExec["med_contreIndications"].ToString();
                string med_amm = SqlExec["med_amm"].ToString();
                int med_derniereEtape = int.Parse(SqlExec["med_derniereEtape"].ToString());
                string med_codeFamille = SqlExec["nomClient"].ToString();

                Medicament leMedicament = new Medicament(depotLegal, med_nomCommercial, med_composition, med_effets, med_contreIndications, med_amm, med_derniereEtape, med_codeFamille);

                Globale.lesMedicaments.Add(depotLegal, leMedicament);

                //objet SQLCommand pour définir la procédure stockée à utiliser
                SqlCommand maRequeteWorkflow = new SqlCommand("prc_listeWorkflow", Globale.cnx);
                maRequeteWorkflow.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramDepotLegal = new SqlParameter("@depotLegal", System.Data.SqlDbType.Int, 10);
                paramDepotLegal.Value = depotLegal;

                //ajout du paramètre à la procédure stockée
                maRequeteWorkflow.Parameters.Add(paramDepotLegal);
                SqlDataReader SqlExecWorkflow = maRequeteWorkflow.ExecuteReader();

                while (SqlExecWorkflow.Read())
                {
                    DateTime wkf_date_decision = DateTime.Parse(SqlExec["wkf_date_decision"].ToString());
                    int wkf_etp_num = int.Parse(SqlExec["wkf_etp_num"].ToString());
                    int wkf_dcs_id = int.Parse(SqlExec["wkf_dcs_id"].ToString());
                    string leDepotLegal = depotLegal;

                    WorkFlow leWorkflow = new WorkFlow(wkf_date_decision, wkf_etp_num, wkf_dcs_id, leDepotLegal);
                    leMedicament.ajouterWorkflow(leWorkflow);

                }
            }
        }

        public static void lireLesDecisions()
        {
            Globale.lesDecisions.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_decision", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int unId = int.Parse(SqlExec["dcs_id"].ToString());
                string unLibelle = SqlExec["dcs_libelle"].ToString();

                Decision uneDecision = new Decision(unId, unLibelle);
                Globale.lesDecisions.Add(uneDecision);
            }
        }

        public static void lireLesEtapes()
        {
            Globale.lesEtapes.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_etape", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int unNum = int.Parse(SqlExec["etp_num"].ToString());
                string unLibelle = SqlExec["etp_libelle"].ToString();
                string uneNorme = SqlExec["etp_norme"].ToString();
                DateTime uneDate = DateTime.Parse(SqlExec["etp_norme_date"].ToString());

                Etape uneEtape = new Etape(unNum, unLibelle, uneNorme, uneDate);
                Globale.lesEtapes.Add(uneEtape);
            }
        }

        public static void lireLesFamilles()
        {
            Globale.lesFamilles.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_famille", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string unCode = SqlExec["fam_code"].ToString();
                string unLibelle = SqlExec["fam_libelle"].ToString();
                int nbMediAmm = int.Parse(SqlExec["fam_nbMediAmm"].ToString());

                Famille uneFamille = new Famille(unCode, unLibelle, nbMediAmm);
                Globale.lesFamilles.Add(unCode, uneFamille);
            }
        }
    }
}
