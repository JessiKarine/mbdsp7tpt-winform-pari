using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    public class Utilisateur
    {
        public String _id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }

        public String Nom { get; set; }
        public String Prenom { get; set; }

        public Utilisateur()
        {
        }

        public Utilisateur(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        public Utilisateur(String _id, string login, string password,string nom,string prenom)
        {
            this._id = _id;
            this.Login = login;
            this.Password = password;
            this.Nom = nom;
            this.Prenom = prenom;
        }

    }
}
