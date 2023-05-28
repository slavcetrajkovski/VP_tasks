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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder ao = new AddOrder();
            if(ao.ShowDialog() == DialogResult.OK)
            {
                lbOrders.Items.Add(ao.order);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if(lbOrders.Items.Count > 0)
            {
                Bill bill = new Bill();
                foreach(object obj in lbOrders.Items)
                {
                    Order order = obj as Order;
                    bill.Total += order.total();
                }
                bill.Time = DateTime.Now;
                lbBills.Items.Add(bill);
                calculate();
                lbOrders.Items.Clear();
            }
        }

        private void calculate()
        {
            int total = 0;
            foreach(object obj in lbBills.Items)
            {
                Bill bill = obj as Bill;
                total += bill.Total;
            }
            tbTotal.Text = total.ToString();
        }
    }
}
