using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    public class Mouvement
    {
        public String _id { get; set; }
        public String date { get; set; }
        public String iduser { get; set; }
        public String idPari { get; set; }
        public double montantDebit { get; set; }
        public double montantCredit { get; set; }

        public Mouvement(string id, string date, string iduser, string idPari, double montantDebit, double montantCredit)
        {
            _id = id;
            this.date = date;
            this.iduser = iduser;
            this.idPari = idPari;
            this.montantDebit = montantDebit;
            this.montantCredit = montantCredit;
        }
    }
}
