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

namespace ParisWinform.Affichages.ListePariCheckbox
{
    public partial class ListePariCheckBox : Form
    {
        public TextBox iduser { get; set; }
        public TextBox idpari { get; set; }
        public TextBox mise { get; set; }
        public ListePariCheckBox()
        {
            InitializeComponent();
        }

        private void ListePariCheckBox_Load(object sender, EventArgs e)
        {
            DisplayTableWithListview();
        }
        private async void DisplayTableWithListview()
        {
            List<Pari> listePari = await PariService.GetParis();

            ((ListBox)this.checkedListBox1).DataSource = listePari;
            ((ListBox)this.checkedListBox1).DisplayMember = "_id";


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                Pari obj = (Pari)checkedListBox1.Items[i];
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection selected = checkedListBox1.CheckedItems;
            IEnumerable<Pari> lm = selected.Cast<Pari>();
            idpari.Text = lm.ElementAt(0)._id;
            iduser.Text = lm.ElementAt(0).idUser;
            mise.Text = "" + lm.ElementAt(0).mise;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_2(object sender, EventArgs e)
        {

        }

    }
}
