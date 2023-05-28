using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public bool codeExists(string code)
        {
            for(int i = 0; i < cbProduction.Items.Count; i++)
            {
                Production production = cbProduction.Items[i] as Production;
                if(production.Code == code)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TvSeries tvseries = new TvSeries(cbProduction.SelectedItem as Production, tbName.Text, (double) nudRating.Value, (int)nudSeasons.Value);
            lbSeries.Items.Add(tvseries);
            calculate();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if(cbProduction.SelectedIndex != -1)
            {
                if (tbName.Text == "")
                {
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    return;
                }
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnAddProduction_Click(object sender, EventArgs e)
        {
           NewProduction newProduction = new NewProduction();
           if(newProduction.ShowDialog() == DialogResult.OK)
            {
                cbProduction.Items.Add(newProduction.production);
             }
        }

        private void calculate()
        {
            if(lbSeries.Items.Count > 0)
            {
                TvSeries maxTvseries = lbSeries.Items[0] as TvSeries;
                double sum = maxTvseries.Rating;
                for (int i = 1; i < lbSeries.Items.Count; i++)
                {
                    TvSeries tvseries = lbSeries.Items[i] as TvSeries;
                    if (tvseries.Seasons > maxTvseries.Seasons)
                    {
                        maxTvseries = tvseries;
                    }
                    sum += tvseries.Rating;
                }

                double average = sum / lbSeries.Items.Count;
                tbAverageRating.Text = average.ToString();
                tbMostSeasons.Text = maxTvseries.Seasons.ToString();
            }
           
        }
    }
}
