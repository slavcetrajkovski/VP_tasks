using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
           AddDriver addDriver = new AddDriver();
            if(addDriver.ShowDialog() == DialogResult.OK)
            {
                lbDriver.Items.Add(addDriver.driver);
            }
        }

        private void lbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteDriver.Enabled = lbDriver.SelectedIndex != -1;
            load();
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if(lbDriver.SelectedIndex != -1)
            {
                if(MessageBox.Show("Дали сте сигурни", "Избриши?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbDriver.Items.RemoveAt(lbDriver.SelectedIndex);
                }
            }
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            if(lbDriver.SelectedIndex != -1) {
                Lap lap = new Lap((int)nudMinutes.Value, (int)nudSeconds.Value);
                Driver driver = lbDriver.SelectedItem as Driver;
                driver.Laps.Add(lap);
                nudMinutes.Value = 0;
                nudSeconds.Value = 0;
                load();
            }
        }

        private void load()
        {
            nudMinutes.Value = 0;
            nudSeconds.Value = 0;
            tbBestLap.Clear();
            Driver driver = lbDriver.SelectedItem as Driver;
            lbLaps.Items.Clear();
            if(lbDriver.SelectedIndex != -1 && driver.Laps.Count > 0)
            {
                Lap minLap = driver.Laps[0] as Lap;
                foreach(Lap lap in driver.Laps)
                {
                    if (nudTime.Value > 0)
                    {
                        if(lap.GetTime() > nudTime.Value)
                        {
                            lbLaps.Items.Add(lap);
                        }
                    }
                    else
                    {
                        lbLaps.Items.Add(lap);
                    }
                    if(minLap.GetTime() > lap.GetTime())
                    {
                        minLap = lap;
                    }
                }
                tbBestLap.Text = minLap.ToString();
            }
        }

        private void lbDriver_SelectedValueChanged(object sender, EventArgs e)
        {
            load();
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            if(nudSeconds.Value == 60)
            {
                nudSeconds.Value = 0;
                nudMinutes.Value += 1;
            }
            if(nudMinutes.Value > 0 && nudSeconds.Value < 0)
            {
                nudMinutes.Value -= 1;
                nudSeconds.Value = 59;
            }
        }

        private void nudTime_ValueChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
