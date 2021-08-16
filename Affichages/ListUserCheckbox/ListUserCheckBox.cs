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

namespace ParisWinform.Affichages.ListUserCheckbox
{
    public partial class ListUserCheckBox : Form
    {
        public TextBox iduser { get; set; }
        public ListUserCheckBox()
        {
            InitializeComponent();
        }

        private void ListUserCheckBox_Load(object sender, EventArgs e)
        {
            DisplayTableWithListview();
        }
        private async void DisplayTableWithListview()
        {
            List<Utilisateur> listeMatch = await UtilisateurService.GetUtilisateurs();

            ((ListBox)this.checkedListBox1).DataSource = listeMatch;
            ((ListBox)this.checkedListBox1).DisplayMember = "Nom";


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                Utilisateur obj = (Utilisateur)checkedListBox1.Items[i];
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection selected = checkedListBox1.CheckedItems;
            IEnumerable<Utilisateur> lm = selected.Cast<Utilisateur>();
            iduser.Text = lm.ElementAt(0)._id;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection selected = checkedListBox1.CheckedItems;
            IEnumerable<Utilisateur> lm = selected.Cast<Utilisateur>();
            iduser.Text = lm.ElementAt(0)._id;
            this.Close();
        }
    }
}
