using ParisWinform.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParisWinform.Affichages.Resultats.resultatDetail
{
    public partial class ResultatDetail : Form
    {
        private ResultatAggregated resultatSelected { get; set; }
        public ResultatDetail()
        {
            InitializeComponent();
        }

        private void ResultatDetail_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = resultatSelected.date.ToString();
        }
    }
}
