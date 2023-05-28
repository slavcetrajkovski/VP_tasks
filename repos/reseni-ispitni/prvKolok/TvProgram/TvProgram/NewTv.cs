using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvProgram
{
    public partial class NewTv : Form
    {
        public TV tv;
        public NewTv()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.tv = new TV(tbName.Text, (int)nudNumber.Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Полето не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void nudNumber_Validating(object sender, CancelEventArgs e)
        {
            Form1 form = new Form1();
            int chanelNumber1 = (int) nudNumber.Value;
            if (form.chanelNumber(chanelNumber1))
            {
                errorProvider1.SetError(nudNumber, "Каналот веќе постои!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudNumber, null);
                e.Cancel= false;
            }
        }
    }
}
