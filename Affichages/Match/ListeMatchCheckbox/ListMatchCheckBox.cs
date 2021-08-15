using ParisWinform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParisWinform.Affichages.Match.ListeMatchCheckbox
{
    public partial class ListMatchCheckBox : Form
    {
        public ListMatchCheckBox()
        {
            InitializeComponent();
        }

        private void ListMatchCheckBox_Load(object sender, EventArgs e)
        {
            DisplayTableWithListview();
        }
        private async void DisplayTableWithListview()
        {
            
        }
    }
}
