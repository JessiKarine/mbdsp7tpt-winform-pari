﻿using ParisWinform.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParisWinform.Affichages.Resultats
{
    public partial class ResultatList : Form
    {
        public ResultatList()
        {
            InitializeComponent();
        }

        private void ResultatList_Load(object sender, EventArgs e)
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
            listView1.Columns.Add("Heure", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Match", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Point Eq. 1", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Point Eq. 2", 100, HorizontalAlignment.Center);

            DocsResultat dcResultat = await Service.ResultatService.GetResultatsDocs();
            List<ResultatAggregated> listeResultat = dcResultat.docs;
            for (int i = 0; i < listeResultat.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = listeResultat[i]._id;
                item.SubItems.Add(listeResultat.ElementAt(i).date.ToString());
                item.SubItems.Add(listeResultat.ElementAt(i).heure);
                item.SubItems.Add(listeResultat.ElementAt(i).idmatch.ElementAt(0).idequipe1.Nom+" VS "+ listeResultat[i].idmatch.ElementAt(0).idequipe2.Nom);
                item.SubItems.Add(""+listeResultat.ElementAt(i).pointequipe1);
                item.SubItems.Add("" + listeResultat.ElementAt(i).pointequipe2);
                listView1.Items.Add(item);
            }

        }
    }
}