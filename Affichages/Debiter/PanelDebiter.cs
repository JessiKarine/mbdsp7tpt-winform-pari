using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParisWinform.Affichages.Debiter
{
    class PanelDebiter : Panel
    {
        private Label label1;
        private string nomUser;
        public PanelDebiter(string nomUser)
        {
            this.nomUser = nomUser;
            this.InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Débiter un compte";
            // 
            // PanelDebiter
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(-2, -2);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(809, 456);
            this.ResumeLayout(false);

        }
    }
}
