using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naracki
{
    public partial class AddOrder : Form
    {
        public Order order;
        public AddOrder()
        {
            InitializeComponent();
            Product product = new Product("Вода", 40);
            cbProducts.Items.Add(product);
            product = new Product("Кафе", 60);
            cbProducts.Items.Add(product);
            product = new Product("Сок", 80);
            cbProducts.Items.Add(product);
            product = new Product("Чоколадо", 70);
            cbProducts.Items.Add(product);
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.order = new Order(cbProducts.SelectedItem as Product, (int)nudQuantity.Value, tbNote.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = cbProducts.SelectedIndex != -1;
        }
    }
}
