using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodrom
{
    public partial class AddAirport : Form
    {
        public Airport airport { get; set; }
        public AddAirport()
        {
            InitializeComponent();
        }

        private void AddAirport_Load(object sender, EventArgs e)
        {

        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if(tbCity.Text == "")
            {
                errorProvider1.SetError(tbCity, "Полето за град несмее да биде празно!"); //sto da se pojavi dokolku ima greska vo poleto tbCity
            }
            else
            {
                errorProvider1.SetError(tbCity, null); 
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Полето за име несмее да биде празно!"); //sto da se pojavi dokolku ima greska vo poleto tbCity
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if(tbCode.Text.Length == 3)
            {
                bool AllUpperLetter = true;
                foreach(char c in tbCode.Text)
                {
                    if (Char.IsLower(c) || !Char.IsLetter(c))
                    {
                        AllUpperLetter = false;
                        break;
                    }
                }

                if(AllUpperLetter)
                {
                    errorProvider1.SetError(tbCode, null);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(tbCode, "Карактерите мора да се големи букви!");
                    e.Cancel= true;
                }
            }
            else
            {
                errorProvider1.SetError(tbCode, "Кодот мора да има точно 3 карактери!");
                e.Cancel = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.airport = new Airport(tbCity.Text, tbName.Text, tbCode.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
