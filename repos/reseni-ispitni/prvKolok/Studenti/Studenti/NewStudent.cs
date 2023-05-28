using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    public partial class NewStudent : Form
    {
        public Student student;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.student = new Student(tbName.Text, tbIndex.Text, tbSurname.Text);
                this.DialogResult = DialogResult.OK;
            }
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
                e.Cancel= false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
