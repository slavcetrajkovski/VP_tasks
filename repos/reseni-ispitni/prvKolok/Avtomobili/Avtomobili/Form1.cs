using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomobili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMarka_Click(object sender, EventArgs e)
        {
            NovaMarka novaMarka = new NovaMarka();
            if(novaMarka.ShowDialog() == DialogResult.OK)
            {
                lbMarki.Items.Add(novaMarka.brand);
                load();
            }
        }

        private void load()
        {
            cbMarka.Items.Clear();
            for(int i = 0; i < lbMarki.Items.Count; i++)
            {
                Brand brand = lbMarki.Items[i] as Brand;
                cbMarka.Items.Add(brand);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            bool flag = true;
            if(cbMarka.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете марка");
                flag = false;
            }
            if(tbModel.Text.Length == 0)
            {
                MessageBox.Show("Изберете модел");
                flag = false;
            }

            if (!flag)
            {
                return;
            }
            Car car = new Car(cbMarka.SelectedItem as Brand, tbModel.Text, (double) nudConsumption.Value, (int) nudPrice.Value);
            lbCarList.Items.Add(car);
            cbMarka.SelectedIndex = -1;
            tbModel.Clear();
            nudConsumption.Value = 0;
            nudConsumption.ResetText();
            nudPrice.Value = 0;
            nudPrice.ResetText();
            calculate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbCarList.SelectedIndex != -1)
            {
                if(MessageBox.Show("Дали сте сигурни дека сакате да го избришете автомобилот?", "Потврда за бришење",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==  DialogResult.Yes)
                {
                    lbCarList.Items.RemoveAt(lbCarList.SelectedIndex);
                    calculate();
                }
            }
        }
        
        private void calculate()
        {
            if(lbCarList.Items.Count > 0)
            {
                Car mostEconomical = lbCarList.Items[0] as Car;
                Car mostExpensive = lbCarList.Items[0] as Car;
                double sum = mostEconomical.Consumption;
                for(int i = 1; i < lbCarList.Items.Count; i++)
                {
                    Car car = lbCarList.Items[i] as Car;
                    if(car.Consumption <  mostEconomical.Consumption)
                    {
                        mostEconomical = car;
                    }
                    if(car.Price > mostExpensive.Price)
                    {
                        mostExpensive = car;
                    }
                    sum += car.Consumption;
                }
                double average = sum / lbCarList.Items.Count;
                tbAverage.Text = String.Format("{0:0.0}", average);
                tbMostEconomical.Text = mostEconomical.ToString();
                tbMostExpensive.Text = mostExpensive.ToString();
            }
            else
            {
                tbAverage.Clear(); tbMostEconomical.Clear(); tbMostExpensive.Clear();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
