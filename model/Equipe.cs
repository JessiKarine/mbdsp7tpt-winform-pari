using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    public class Equipe
    {
        public String Id { get; set; }
        public String Nom { get; set; }
        public String Image { get; set; }
        public Equipe()
        {
        }
        public Equipe(String id, String nom,String image)
        {
            this.Id = id;
            this.Nom = nom;
            this.Image = image;
        }
    }
}
