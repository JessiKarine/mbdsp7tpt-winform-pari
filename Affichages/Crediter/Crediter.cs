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

namespace ParisWinform.Affichages.Crediter
{
    public partial class Crediter : Form
    {
        public Crediter()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            String result = await MouvementService.crediterJoueur(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (result != null)
            {
                System.Windows.Forms.MessageBox.Show(result);
                this.Hide();
            }
        }
    }
}
