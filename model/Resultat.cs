using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    class Resultat
    {
        public String _id { get; set; }
        public DateTime date { get; set; }
        public Match idmatch { get; set; }
        public String heure { get; set; }
        public double pointequipe1 { get; set; }
        public double pointequipe2 { get; set; }

        public Resultat(string id, String date, Match idmatch, String heure, double pointequipe1, double pointequipe2)
        {
            this._id = id;
            this.date = DateTime.Parse(date);
            this.idmatch = idmatch;
            this.heure = heure;
            this.pointequipe1 = pointequipe1;
            this.pointequipe2 = pointequipe2;
        }
    }
}
