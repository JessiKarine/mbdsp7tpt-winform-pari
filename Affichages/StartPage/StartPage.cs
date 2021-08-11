using ParisWinform.Affichages.Crediter;
using ParisWinform.Affichages.ListeJoueurs;
using ParisWinform.Affichages.Match.ListeMatch;
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

namespace ParisWinform
{
    public partial class StartPage : Form
    {
        private Utilisateur user;
        public StartPage(Utilisateur u)
        {
            user = u;
            InitializeComponent();
            PanelListeJoueurs listeJoueur = new PanelListeJoueurs(user.Login);
            this.Controls.Add(listeJoueur);
            listeJoueur.ResumeLayout(false);
            listeJoueur.PerformLayout();
            this.ResumeLayout(false);
        }
        
        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeDesJoueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelListeJoueurs listeJoueur = new PanelListeJoueurs(user.Login);
            listeJoueur.Show();
        }

        private void débiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debiter deb =new Debiter();
            deb.Show();
        }

        private void créditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crediter cred =new Crediter();
            cred.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeMatch match =new ListeMatch();
            match.Show();
        }

        private void déconnexionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
