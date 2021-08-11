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

namespace ParisWinform.Affichages.Match.ListeMatch
{
    public partial class ListeMatch : Form
    {
        public ListeMatch()
        {
            InitializeComponent();
        }

        private void ListeMatch_Load(object sender, EventArgs e)
        {
            DisplayTableWithListview();
        }
        private void DisplayTableWithListview()
        {
            listView1.GridLines = true;// Whether the grid lines are displayed
            listView1.FullRowSelect = true;// Whether to select the entire line

            listView1.View = View.Details;// Set display mode
            listView1.Scrollable = true;// Whether to show the scroll bar automatically
            listView1.MultiSelect = false;// Is it possible to select multiple lines

            // Add header(column)
            listView1.Columns.Add("id", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Heure", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Categorie", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Equipe 1", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Equipe 2", 100, HorizontalAlignment.Center);


            model.Match m1 = new model.Match("60fc41e68d4114089a90cb56", "2021-10 -17", "18:00",new Categorie("2","Premier League","-"), 4, 5, "A venir", 0, new Equipe("1", "Arsenal", "Arsenal.jpg"), new Equipe("2", "Manchester", "Manchester.jpg"));
            
            ListViewItem item = new ListViewItem();
            item.SubItems.Clear();

            item.SubItems[0].Text =m1._id;
            item.SubItems.Add(m1.date);
            item.SubItems.Add(m1.heure);
            item.SubItems.Add(m1.idcategorie.Nom);
            item.SubItems.Add(m1.idequipe1.Nom);
            item.SubItems.Add(m1.idequipe2.Nom);
            listView1.Items.Add(item);
            
        }
    }
}
