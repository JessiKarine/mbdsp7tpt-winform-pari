using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    public class Categorie
    {
        public String Id { get; set; }
        public String Nom { get; set; }
        public String Description { get; set; }

        public Categorie(string id, string nom, string description)
        {
            Id = id;
            Nom = nom;
            Description = description;
        }
    }
}
