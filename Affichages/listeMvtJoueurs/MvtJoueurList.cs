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

namespace ParisWinform.Affichages.listeMvtJoueurs
{
    public partial class MvtJoueurList : Form
    {
        public MvtJoueurList()
        {
            InitializeComponent();
        }

        private void MvtJoueurList_Load(object sender, EventArgs e)
        {
            DisplayTableWithListview("");
        }
       
        private async void DisplayTableWithListview(String filtre)
        {
            listView1.GridLines = true;// Whether the grid lines are displayed
            listView1.FullRowSelect = true;// Whether to select the entire line

            listView1.View = View.Details;// Set display mode
            listView1.Scrollable = true;// Whether to show the scroll bar automatically
            listView1.MultiSelect = false;// Is it possible to select multiple lines

            // Add header(column)
            listView1.Columns.Add("id", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("User", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Pari", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Débit", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Crédit", 100, HorizontalAlignment.Center);

            List<model.Mouvement> listeMvt = await MouvementService.getMouvements();

            for (int i = 0; i < listeMvt.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = listeMvt.ElementAt(i)._id;
                item.SubItems.Add(listeMvt.ElementAt(i).date);
                item.SubItems.Add(listeMvt.ElementAt(i).iduser);
                item.SubItems.Add(listeMvt.ElementAt(i).idPari);
                item.SubItems.Add(""+listeMvt.ElementAt(i).montantDebit);
                item.SubItems.Add(""+listeMvt.ElementAt(i).montantCredit);
                listView1.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listView1.SelectedItems[0].Text);
        }
    }
}
