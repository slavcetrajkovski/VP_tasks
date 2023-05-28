using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serija
{
    public partial class NewProduction : Form
    {
        public Production production;
        public NewProduction()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.production = new Production(tbName.Text, tbCode.Text);
                this.DialogResult = DialogResult.OK;
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text == "")
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


        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            Form1 form1 = new Form1();
            if (tbCode.Text == "")
            {
                errorProvider1.SetError(tbCode, "Полето не смее да биде празно!");
                e.Cancel = true;
            }
            else if (form1.codeExists(tbCode.Text))
            {
                errorProvider1.SetError(tbCode, "Шифрата веќе постои!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCode, null);
                e.Cancel = false;
            }
        }
    }
}
