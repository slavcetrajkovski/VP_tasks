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
    public partial class AddLine : Form
    {
        public Line line { get; set; }
        public AddLine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            line = new Line(tbDestination.Text, (int)nudHours.Value, (int)nudMinutes.Value, (int)nudPrice.Value); 
            DialogResult = DialogResult.OK;
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestination.Text == "")
            {
                errorProvider1.SetError(tbDestination, "Полето не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
                e.Cancel = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
