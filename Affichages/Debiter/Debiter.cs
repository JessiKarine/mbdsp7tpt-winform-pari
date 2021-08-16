using ParisWinform.Affichages.ListePariCheckbox;
using ParisWinform.Affichages.ListUserCheckbox;
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

        private void button2_Click(object sender, EventArgs e)
        {
            ListUserCheckBox listUser =new ListUserCheckBox();
            listUser.iduser =this.textBox2;
            listUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListePariCheckBox listUser = new ListePariCheckBox();
            listUser.iduser = this.textBox2;
            listUser.mise =this.textBox4;
            listUser.idpari = this.textBox1;
            listUser.Show();
        }

        private void Debiter_Load(object sender, EventArgs e)
        {

        }
    }
}
