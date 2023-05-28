using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtobusi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            NewBus newBus = new NewBus();
            if(newBus.ShowDialog() == DialogResult.OK) 
            {
                lbBus.Items.Add(newBus.bus);
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if(lbBus.SelectedIndex != -1)
            {
                if(MessageBox.Show("Дали сте сигурни за вришењето на автобусот?", "Бришење", MessageBoxButtons.YesNo) 
                    == DialogResult.Yes)
                {
                    lbBus.Items.RemoveAt(lbBus.SelectedIndex);
                    loadLines();
                }
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if(lbBus.SelectedIndex != -1) 
            {
                AddLine addLine = new AddLine();
                if (addLine.ShowDialog() == DialogResult.OK)
                {
                    Bus SelectedBus = lbBus.Items[lbBus.SelectedIndex] as Bus;
                    SelectedBus.lines.Add(addLine.line);
                    loadLines();
                }
            }
        }

        private void loadLines()
        {
            tbAverageLine.Clear();     
            tbMostExpensive.Clear();
            lbLines.Items.Clear();
            if(lbBus.SelectedIndex != -1) 
            {
                Bus SelectedBus = lbBus.Items[lbBus.SelectedIndex] as Bus;
                if(SelectedBus.lines.Count > 0)
                {
                    Line maxLine = SelectedBus.lines[0];
                    double totalPrice = 0;
                    foreach (Line line in SelectedBus.lines)
                    {
                        lbLines.Items.Add(line);
                        if (line.Price > maxLine.Price)
                        {
                            maxLine = line;
                        }
                        totalPrice += line.Price;
                    }
                    tbAverageLine.Text = String.Format("{0:0.0}", totalPrice / lbLines.Items.Count);
                    tbMostExpensive.Text = maxLine.ToString();
                }
                
            }
        }

        private void lbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLines();
        }

        private void lbBus_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLines();
        }
    }
}
