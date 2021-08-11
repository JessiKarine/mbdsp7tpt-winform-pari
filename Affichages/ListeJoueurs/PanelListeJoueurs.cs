using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParisWinform.Affichages.ListeJoueurs
{
    public class PanelListeJoueurs : Panel
    {

        private Label lab;
        private string nomUser;
        public PanelListeJoueurs(string nomUser)
        {
            this.nomUser = nomUser;
            this.InitializeComponent();
        }
        private void InitializeComponent()
        {
            //about the label
            lab=new Label();
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lab.Location = new System.Drawing.Point(250, 45);
            lab.Name = "label1";
            lab.Size = new System.Drawing.Size(129, 20);
            lab.TabIndex = 0;
            lab.Text = "Liste des joeurs salut "+ nomUser;

            //about the panel
            this.BackColor = Color.White;
            this.SuspendLayout();
            this.Controls.Add(this.lab);
            this.Location = new System.Drawing.Point(-2, -2);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(809, 456);
            this.TabIndex = 0;
        }
    }
}
