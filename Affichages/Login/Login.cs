using ParisWinform.model;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            WebService.InitializeClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public async Task CallLoginService(string login, string mdp)
        {
            await LoginService.CallLogin(login, mdp);
        }

        public async void Button1_Click(object sender, EventArgs e)
        {
            Utilisateur util=await LoginService.CallLogin(textBox1.Text, textBox2.Text);
            if (util != null)
            {
                StartPage lj = new StartPage(util);
                lj.Show();
                this.Hide();
            }
        }
        
    }
}
