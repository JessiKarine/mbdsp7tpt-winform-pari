using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    public class Utilisateur
    {
        public String Id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }

        public Utilisateur()
        {
        }

        public Utilisateur(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        
    }
}
