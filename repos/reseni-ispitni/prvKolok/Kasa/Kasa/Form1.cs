using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            if(addProduct.ShowDialog() == DialogResult.OK)
            {
                foreach(Product product in lbProducts.Items)
                {
                    if(product.Code == addProduct.product.Code)
                    {
                        MessageBox.Show("Продуктот со тој код веќе постои во листата");
                        return;
                    }
                }
                lbProducts.Items.Add(addProduct.product);
            }
        }

       private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddAccount.Enabled = lbProducts.SelectedIndex != -1; //ne raboti
            nudQuantity.Enabled = lbProducts.SelectedIndex != -1; //ne raboti
        } 

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if(lbProducts.SelectedIndex != -1)
            {
                Product p = lbProducts.SelectedItem as Product;
                Item item = new Item(p, (int) nudQuantity.Value);
                lbAccount.Items.Add(item);
                calculate();
            }
        }

        private void calculate()
        {
            double total = 0;
            foreach(Item item in lbAccount.Items)
            {
                total += item.price();
            }
            tbTotal.Text = string.Format("{0:0.00} ден", total);
            tbPayment.Text = string.Format("{0:00} ден", total * (double)(1 + nudTax.Value / 100));
        }

        private void nudTax_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни?", "Сигурни", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbAccount.Items.RemoveAt(lbAccount.SelectedIndex);
                calculate();
            }
        }

        private void lbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = lbAccount.SelectedIndex != -1; //ne raboti
        }
    }
}
