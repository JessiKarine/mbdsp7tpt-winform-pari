using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    public class Match
    {
        public String _id { get; set; }
        public String date { get; set; }
        public String heure { get; set; }
        public double coteequipe1 { get; set; }
        public double coteequipe2 { get; set; }
        public String etat { get; set; }
        public double coteMatchNull { get; set; }
        public Equipe idequipe1 { get; set; }
        public Equipe idequipe2 { get; set; }
        public Categorie idcategorie { get; set; }

        public Match(string id, String date, string heure, Categorie idcategorie, double coteequipe1, double coteequipe2, string etat, double coteMatchNull, Equipe equipe1, Equipe equipe2)
        {
            _id = id;
            this.date = date;
            this.heure = heure;
            this.coteequipe1 = coteequipe1;
            this.coteequipe2 = coteequipe2;
            this.etat = etat;
            this.coteMatchNull = coteMatchNull;
            this.idequipe1 = equipe1;
            this.idequipe2 = equipe2;
            this.idcategorie = idcategorie;
        }

    }
}
