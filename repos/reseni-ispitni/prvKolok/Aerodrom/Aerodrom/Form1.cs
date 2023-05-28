using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodrom
{
    public partial class Form1 : Form
    {
        public List<Airport> Airports { get; set; }
        public Form1()
        {
            InitializeComponent();
            Airports = new List<Airport>();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddAirport addAirport = new AddAirport();
            if(addAirport.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(addAirport.airport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex == -1)
            {
                return;
            }

            DialogResult dg = MessageBox.Show("Дали си сигурен?", "Дали си сигурен?", MessageBoxButtons.OKCancel);
            if(dg == DialogResult.OK)
            {
                int selectedIndex = lbAirports.SelectedIndex;
                lbAirports.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex != -1)
            {
                AddDestination AddDestinationForm = new AddDestination();
                if(AddDestinationForm.ShowDialog() == DialogResult.OK)
                {
                    Airport SelectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                    SelectedAirport.Destinations.Add(AddDestinationForm.CreatedDestination);
                    loadDestination();
                }
            }
        }

        private void loadDestination()
        {
            lbDestinations.Items.Clear();
            tbAverage.Clear();
            tbMostExpensive.Clear();
            if (lbAirports.SelectedIndex != -1)
            {  
                Airport SelectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                foreach (Destination destination in SelectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                }

                //average distance
                double sum = 0;     
                foreach(Destination destination in SelectedAirport.Destinations)
                {
                    sum += destination.Distance;
                }
                if(SelectedAirport.Destinations.Count > 0)
                {
                    double average = sum / SelectedAirport.Destinations.Count;
                    tbAverage.Text = average.ToString(); 
                }
                else
                {
                    tbAverage.Text = "Аеродромот нема дестинации";
                }

                //most expensive destination
                if(SelectedAirport.Destinations.Count > 0)
                {
                    Destination max = SelectedAirport.Destinations[0];
                    for(int i = 0; i < SelectedAirport.Destinations.Count; i++)
                    {
                        if (SelectedAirport.Destinations[i].Price > max.Price)
                        {
                            max = SelectedAirport.Destinations[i];
                        }
                    }
                    tbMostExpensive.Text = max.ToString();
                }
                else
                {
                    tbMostExpensive.Text = "Аеродромот нема дестинации";
                }
                
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestination();
        }

        private void lbAirports_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDestination();
        } 
    }
}
