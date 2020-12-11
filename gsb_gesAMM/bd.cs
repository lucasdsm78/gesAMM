using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace gsb_gesAMM
{
    class bd
    {
        public static string GenerateSHA256Hash(String input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static Boolean verifConnexion(string username, string password)
        {
            int idx = 0;
            Boolean trouve = false;

            while (idx < Globale.lesUtilisateurs.Count && !trouve)
            {
                Utilisateur unUtilisateur = Globale.lesUtilisateurs.ElementAt(idx);

                if (unUtilisateur.getUsername() == username && unUtilisateur.getPassword() == GenerateSHA256Hash(password))
                {
                    trouve = true;
                }
                else
                {
                    idx++;
                }
            }

            return trouve;
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
                Medicament unMedicament = null;
                int? med_derniereEtapeNull = 0;

                string depotLegal = SqlExec["med_depotLegal"].ToString();
                string med_nomCommercial = SqlExec["med_nomCommercial"].ToString();
                string med_composition = SqlExec["med_composition"].ToString();
                string med_effets = SqlExec["med_effets"].ToString();
                string med_contreIndications = SqlExec["med_contreIndications"].ToString();
                string med_amm = SqlExec["med_amm"].ToString();
                string med_codeFamille = SqlExec["med_codeFamille"].ToString();

                if (int.TryParse(SqlExec["med_derniereEtape"].ToString(), out int med_derniereEtape))
                {
                    unMedicament = new Medicament(depotLegal, med_nomCommercial, med_composition, med_effets, med_contreIndications, med_amm, med_derniereEtape, med_codeFamille);
                }
                else
                {
                    unMedicament = new Medicament(depotLegal, med_nomCommercial, med_composition, med_effets, med_contreIndications, med_amm, med_derniereEtapeNull.GetValueOrDefault(), med_codeFamille);
                }

                Globale.lesMedicaments.Add(depotLegal, unMedicament);

                //objet SQLCommand pour définir la procédure stockée à utiliser
                SqlCommand maRequeteWorkflow = new SqlCommand("prc_listeWorkflow", Globale.cnx);
                maRequeteWorkflow.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramDepotLegal = new SqlParameter("@numMedicament", System.Data.SqlDbType.NVarChar, 10);
                paramDepotLegal.Value = depotLegal;

                //ajout du paramètre à la procédure stockée
                maRequeteWorkflow.Parameters.Add(paramDepotLegal);
                SqlDataReader SqlExecWorkflow = maRequeteWorkflow.ExecuteReader();

                while (SqlExecWorkflow.Read())
                {
                    WorkFlow unWorkflow = null;
                    DateTime? uneDateNull = null;

                    int wkf_etp_num = int.Parse(SqlExecWorkflow["wkf_etp_num"].ToString());
                    int wkf_dcs_id = int.Parse(SqlExecWorkflow["wkf_dcs_id"].ToString());
                    string leDepotLegal = depotLegal;

                    if (DateTime.TryParse(SqlExecWorkflow["wkf_date_decision"].ToString(), out DateTime uneDate))
                    {
                        unWorkflow = new WorkFlow(uneDate, wkf_etp_num, wkf_dcs_id, leDepotLegal);
                    }
                    else
                    {
                        unWorkflow = new WorkFlow(uneDateNull.GetValueOrDefault(), wkf_etp_num, wkf_dcs_id, leDepotLegal);
                    }

                    unMedicament.ajouterWorkflow(unWorkflow);
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
                Etape uneEtape = null;
                DateTime? uneDateNull = null;
                int? etpUserNull = 0;

                int unNum = int.Parse(SqlExec["etp_num"].ToString());
                string unLibelle = SqlExec["etp_libelle"].ToString();
                string uneNorme = SqlExec["etp_norme"].ToString();

                if (DateTime.TryParse(SqlExec["etp_date_norme"].ToString(), out DateTime uneDate) && int.TryParse(SqlExec["etp_user_id"].ToString(), out int etpUser))
                {
                    uneEtape = new EtapeNormee(unNum, unLibelle, uneNorme, uneDate, etpUser);
                }
                else
                {
                    uneEtape = new Etape(unNum, unLibelle);
                }

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
                Famille uneFamille = null;
                int? nbMediAmmNull = 0;

                string unCode = SqlExec["fam_code"].ToString();
                string unLibelle = SqlExec["fam_libelle"].ToString();

                if (int.TryParse(SqlExec["fam_nbMediAmm"].ToString(), out int nbMediAmm))
                {
                    uneFamille = new Famille(unCode, unLibelle, nbMediAmm);
                }
                else
                {
                    nbMediAmmNull = null;
                    uneFamille = new Famille(unCode, unLibelle, nbMediAmmNull.GetValueOrDefault());
                }

                Globale.lesFamilles.Add(unCode, uneFamille);
            }

        }

        public static void lireLesUtilisateurs()
        {
            Globale.lesUtilisateurs.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_utilisateur", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int unId = int.Parse(SqlExec["usr_id"].ToString());
                string unPseudo = SqlExec["usr_username"].ToString();
                string unPassword = SqlExec["usr_password"].ToString();

                Utilisateur unUtilisateur = new Utilisateur(unId, unPseudo, unPassword);
                Globale.lesUtilisateurs.Add(unUtilisateur);
            }
        }

        public static Boolean ajouterWorkflow(DateTime laDateDecision, int leWkfEtpNum, int leWkfDcsId, string leWkfMedId)
        {
            SqlCommand maRequete = new SqlCommand("prc_ajouterWorkflow", Globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramDateDecision = new SqlParameter("@laDateDecision", System.Data.SqlDbType.DateTime, 40);
            paramDateDecision.Value = laDateDecision;

            SqlParameter paramWkfEtpNum = new SqlParameter("@leWkfEtpNum", System.Data.SqlDbType.Int, 30);
            paramWkfEtpNum.Value = leWkfEtpNum;

            SqlParameter paramWkfDcsId = new SqlParameter("@leWkfDcsdId", System.Data.SqlDbType.Int, 30);
            paramWkfDcsId.Value = leWkfDcsId;

            SqlParameter paramWkfMedId = new SqlParameter("@leWkfMedId", System.Data.SqlDbType.NVarChar, 30);
            paramWkfMedId.Value = leWkfMedId;

            maRequete.Parameters.Add(paramDateDecision);
            maRequete.Parameters.Add(paramWkfEtpNum);
            maRequete.Parameters.Add(paramWkfDcsId);
            maRequete.Parameters.Add(paramWkfMedId);

            WorkFlow newWorkflow = new WorkFlow(laDateDecision, leWkfEtpNum, leWkfDcsId, leWkfMedId);

            // exécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                Globale.lesMedicaments[leWkfMedId].ajouterWorkflow(newWorkflow);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static List<Etape> lireLesEtapesNormees()
        {
            List<Etape> lesEtapesNormees = new List<Etape>();
            lesEtapesNormees.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_etape_normee", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int etpNum = int.Parse(SqlExec["etp_num"].ToString());
                string etp_libelle = SqlExec["etp_libelle"].ToString();
                string etp_norme = SqlExec["etp_norme"].ToString();
                DateTime etp_date_norme = DateTime.Parse(SqlExec["etp_date_norme"].ToString());
                int etpUser = int.Parse(SqlExec["etp_user_id"].ToString());

                Etape uneEtape = new Etape(etpNum, etp_libelle, etp_norme, etp_date_norme, etpUser);
                lesEtapesNormees.Add(uneEtape);
            }
            return lesEtapesNormees;
        }

        public static Boolean MAJEtapeNormee(DateTime etp_date_norme, string etp_norme, int etp_num, int etp_user)
        {
            SqlCommand maRequete = new SqlCommand("prc_MAJ_etape_normee", Globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramEtpDateNormee = new SqlParameter("@etp_date_norme", System.Data.SqlDbType.DateTime, 40);
            paramEtpDateNormee.Value = etp_date_norme;

            SqlParameter paramEtpNorme = new SqlParameter("@etp_norme", System.Data.SqlDbType.NVarChar, 30);
            paramEtpNorme.Value = etp_norme;

            SqlParameter paramEtpNum = new SqlParameter("@etp_num", System.Data.SqlDbType.Int, 30);
            paramEtpNum.Value = etp_num;

            SqlParameter paramEtpUser = new SqlParameter("@etp_user", System.Data.SqlDbType.Int, 30);
            paramEtpUser.Value = etp_user;

            maRequete.Parameters.Add(paramEtpDateNormee);
            maRequete.Parameters.Add(paramEtpNorme);
            maRequete.Parameters.Add(paramEtpNum);


            // exécuter la procedure stockée
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

        public static Boolean lireDerniereEtapeNormee(int etp_num)
        {
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_derniereEtapeNormee", Globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            WorkFlow unWorkflow = null;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                DateTime max_derniereEtape = DateTime.Parse(SqlExec["max_derniereEtape"].ToString());
                int wkf_dcs_id = int.Parse(SqlExec["wkf_dcs_id"].ToString());
                int wkf_etp_num = int.Parse(SqlExec["wkf_etp_id"].ToString());
                string wkf_med_id = SqlExec["wkf_med_id"].ToString();

                unWorkflow = new WorkFlow(max_derniereEtape, wkf_etp_num, wkf_dcs_id, wkf_med_id);
            }

            if(unWorkflow.getWkfDcsId() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
