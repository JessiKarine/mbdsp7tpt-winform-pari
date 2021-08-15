using ParisWinform.model;
using ParisWinform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParisWinform.Affichages.Match.ListeMatch
{
    public partial class ListeMatch : Form
    {
        private String filteredCateg="";
        public ListeMatch()
        {
            InitializeComponent();
        }

        private void ListeMatch_Load(object sender, EventArgs e)
        {
            DisplayTableWithListview(filteredCateg);
        }
        private async void DisplayTableWithListview(String filtre)
        {
            listView1.GridLines = true;// Whether the grid lines are displayed
            listView1.FullRowSelect = true;// Whether to select the entire line

            listView1.View = View.Details;// Set display mode
            listView1.Scrollable = true;// Whether to show the scroll bar automatically
            listView1.MultiSelect = false;// Is it possible to select multiple lines

            // Add header(column)
            //listView1.Columns.Add("id", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Heure", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Categorie", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Equipe 1", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Equipe 2", 100, HorizontalAlignment.Center);

            

            List<model.Match>  listeMatch=await MatchService.GetMatches(filtre);
            
            for (int i = 0; i < listeMatch.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = listeMatch.ElementAt(i).date;
                item.SubItems.Add(listeMatch.ElementAt(i).heure);
                item.SubItems.Add(listeMatch.ElementAt(i).idcategorie.Nom);
                item.SubItems.Add(listeMatch.ElementAt(i).idequipe1.Nom);
                item.SubItems.Add(listeMatch.ElementAt(i).idequipe2.Nom);
                listView1.Items.Add(item);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String filtreCategorie = "";
            if (textBox1.Text != null) filtreCategorie = textBox1.Text;
            filteredCateg = filtreCategorie;
            listView1.Clear();
            this.ListeMatch_Load(sender, e);
        }
    }
}
