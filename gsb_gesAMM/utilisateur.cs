using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_gesAMM
{
    class utilisateur
    {
        private int idUtilisateur;
        private string username;
        private string password;

        public utilisateur(int leId, string leUsername, string lePassword)
        {
            this.idUtilisateur = leId;
            this.username = leUsername;
            this.password = lePassword;
        }

        //getters
        
        public int getIdUtilisateur() { return this.idUtilisateur; }
        public string getUsername() { return this.username; }
        public string getPassword() { return this.password; }

    }
}
