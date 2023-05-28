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
    public partial class AddDestination : Form
    {
        public Destination CreatedDestination { get; set; }
        public AddDestination()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreatedDestination = new Destination(tbName.Text, (int)nudLength.Value, (int)nudPrice.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddDestination_Load(object sender, EventArgs e)
        {

        }
    }
}
