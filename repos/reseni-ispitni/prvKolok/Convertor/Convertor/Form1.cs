using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Form1 : Form
    {
        Conversion conversion;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddConvertor ac = new AddConvertor();
            if(ac.ShowDialog() == DialogResult.OK)
            {
                lbCurrency.Items.Add(ac.Conversion);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbCurrency.SelectedIndex != -1)
            {
                if(MessageBox.Show("Дали сте сигурни?", "Избриши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbCurrency.Items.RemoveAt(lbCurrency.SelectedIndex);
                    nudFrom.Value = 0; 
                    nudTo.Value = 0;
                    labelFrom.Text = "FROM";
                    labelTo.Text = "TO";
                }
            }
        }

        private void lbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbCurrency.SelectedIndex != -1)
            {
                conversion = lbCurrency.SelectedItem as Conversion;
                labelFrom.Text = conversion.ConvertFrom;
                labelTo.Text = conversion.ConvertTo;
                nudFrom.Value = 1;
                nudTo.Value = nudFrom.Value * conversion.Multiplier;
            }
            nudFrom.Enabled = lbCurrency.SelectedIndex != -1;
            nudTo.Enabled = lbCurrency.SelectedIndex != -1;
        }

        private void nudFrom_ValueChanged(object sender, EventArgs e)
        {
            nudTo.Value = nudFrom.Value * conversion.Multiplier;
        }

        private void nudTo_ValueChanged(object sender, EventArgs e)
        {
            nudFrom.Value = nudTo.Value / conversion.Multiplier;
        }
    }
}
