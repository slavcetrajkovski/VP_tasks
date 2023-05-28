using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VremenskaPrognoza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                AddWeather addWeather = new AddWeather();
            if (addWeather.ShowDialog() == DialogResult.OK)
            {
                lbDate.Items.Add(addWeather.date);
            }
   
        }

        private void lbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Date date = lbDate.SelectedItem as Date;
            lblDate.Text = date.ToString();
            if(date.weather == null)
            {
                nudMax.Value = 0;
                nudMin.Value = 0;
                return;
            }
            nudMax.Value = date.weather.Max;
            nudMin.Value = date.weather.Min;
           
        }

        void findMaxMin()
        {
            Date maxDate = lbDate.Items[0] as Date;
            Date minDate = lbDate.Items[0] as Date;
            int min = minDate.weather.Min;
            int max = maxDate.weather.Max;
            foreach(Date date in lbDate.Items)
            {
                if(date.weather.Max > max)
                {
                    maxDate = date;
                }

                if(date.weather.Min < min)
                {
                    minDate = date;
                }
            }
            lblMax.Text = maxDate.ToString();
            lblMin.Text = minDate.ToString();
        }

        private void update()
        {
            int max = (int) nudMax.Value;
            int min = (int) nudMin.Value;
            Date date = lbDate.SelectedItem as Date;
            date.createWeather(max, min);
            findMaxMin();
        }

        private void nudMax_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
