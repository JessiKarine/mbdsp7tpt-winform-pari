using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    public class Pari
    {
        public String _id { get; set; }
        public String idUser { get; set; }
        public double mise { get; set; }

        public Pari(string id, string idUser, double mise)
        {
            _id = id;
            this.idUser = idUser;
            this.mise = mise;
        }
    }
}
