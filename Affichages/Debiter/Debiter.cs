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

namespace ParisWinform
{
    public partial class Debiter : Form
    {
        public Debiter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private async void button1_Click(object sender, EventArgs e)
        {
            String result=await MouvementService.debiterJoueur(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (result != null) {
                System.Windows.Forms.MessageBox.Show(result);
                this.Hide();
            }
        }
    }
}
