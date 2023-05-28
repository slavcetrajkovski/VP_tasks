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
    public partial class NewBus : Form
    {
        public Bus bus { get; set; }
        public NewBus()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.bus = new Bus(tbName.Text, tbRegistration.Text, cbLocal.Checked);
            this.DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Полето за име не смее да е празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbRegistration_Validating(object sender, CancelEventArgs e)
        {
            if( tbRegistration.Text.Length != 4 )
            {
                errorProvider1.SetError(tbRegistration, "Регирстрација мора да има точно 4 цифри!");
                e.Cancel= true;
            }
            else
            {
                bool AllDigits = true;
                foreach(char c in tbRegistration.Text )
                {
                    if (!Char.IsDigit(c))
                    {
                        AllDigits = false;
                        break;
                    }
                }

                if( AllDigits )
                {
                    errorProvider1.SetError(tbRegistration, null);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(tbRegistration, "Сите карактери мора да бидат цифри");
                    e.Cancel = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
