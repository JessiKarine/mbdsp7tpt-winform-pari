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

namespace ParisWinform.Affichages.Match.ListeMatchCheckbox
{
    public partial class ListMatchCheckBox : Form
    {
        public TextBox idmatch { get; set; }
        public ListMatchCheckBox()
        {
            InitializeComponent();
        }

        private void ListMatchCheckBox_Load(object sender, EventArgs e)
        {
            DisplayTableWithListview();
        }
        private async void DisplayTableWithListview()
        {
            List<model.Match> listeMatch = await MatchService.GetMatches("");

            ((ListBox)this.checkedListBox1).DataSource = listeMatch;
            ((ListBox)this.checkedListBox1).DisplayMember = "_id";


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                model.Match obj = (model.Match)checkedListBox1.Items[i];
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection selected = checkedListBox1.CheckedItems;
            IEnumerable<model.Match> lm = selected.Cast<model.Match>();
            idmatch.Text =lm.ElementAt(0)._id;
            this.Close();
        }
    }
}
