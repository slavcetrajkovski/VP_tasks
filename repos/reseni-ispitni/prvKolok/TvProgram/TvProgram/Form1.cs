using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
        }



        public bool chanelNumber(int chanelNumber)
        {
            for (int i = 0; i < cbTv.Items.Count; i++)
            {
                TV tv = cbTv.Items[i] as TV;
                if (chanelNumber == tv.Number)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAddTv_Click(object sender, EventArgs e)
        {
            NewTv newTv = new NewTv();
            if(newTv.ShowDialog() == DialogResult.OK)
            {
                cbTv.Items.Add(newTv.tv);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if(cbTv.SelectedIndex == -1)
            {
                if(tbName.Text == "")
                {
                    btnAdd.Enabled = false;
                }
                else
                {
                    btnAdd.Enabled = true;
                }
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true; 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TVProgram tvprogram = new TVProgram(tbName.Text, (int)nudMin.Value);
            TV tv = cbTv.SelectedItem as TV;
            tv.tvProgram.Add(tvprogram);
            fillList();
            calculate();
        }

        private void calculate()
        {
            tbAverage.Clear();
            if(lbSeries.Items.Count > 0)
            {
                double sum = 0;
                for(int i = 0; i < lbSeries.Items.Count; i++) 
                {
                    TVProgram tvprogram = lbSeries.Items[i] as TVProgram;
                    sum += tvprogram.Duration;
                }
                tbAverage.Text = string.Format("{0:0.0}", sum / lbSeries.Items.Count);
            }
        }

        private void fillList()
        {
            if(cbTv.SelectedIndex != -1)
            {
                lbSeries.Items.Clear();
                TV tv = cbTv.SelectedItem as TV;
                lblTV.Text = tv.Name;
                foreach(TVProgram tvProg in tv.tvProgram)
                {
                    lbSeries.Items.Add(tvProg);
                }
                calculate();
            }
        }

        private void cbTv_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate();
            fillList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbSeries.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали си сигурен?", "Бришење", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbSeries.Items.RemoveAt(lbSeries.SelectedIndex);
                }
            }
         
        }
    }
}

