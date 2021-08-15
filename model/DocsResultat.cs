using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisWinform.model
{
    class DocsResultat
    {
        public List<ResultatAggregated> docs { get; set; }
        public DocsResultat(List<ResultatAggregated> docs)
        {
            this.docs = docs;
        }
    }
}
