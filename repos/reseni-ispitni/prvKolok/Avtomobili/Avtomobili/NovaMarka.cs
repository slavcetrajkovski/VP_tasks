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
    public partial class NovaMarka : Form
    {
        public Brand brand { get; set; }
        public NovaMarka()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.brand = new Brand(tbName.Text, tbCode.Text);
            this.DialogResult = DialogResult.OK;    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Делот за Име, мора да биде пополнет!");
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
            if (tbCode.Text == "")
            {
                errorProvider1.SetError(tbCode, "Делот за Шифра, мора да биде пополнет!");
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
