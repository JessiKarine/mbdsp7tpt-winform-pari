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

namespace ParisWinform.Affichages.ResultatSaisie
{
    public partial class ResultatSaisie : Form
    {
        public ResultatSaisie()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String result = await ResultatService.createResultat(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text); ;
            if (result != null)
            {
                System.Windows.Forms.MessageBox.Show(result);
                this.Hide();
            }
            
        }
    }
}
