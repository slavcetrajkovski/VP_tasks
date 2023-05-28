using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregled
{
    public partial class Form1 : Form
    {
        public Patient patient;
        public Form1()
        {
            InitializeComponent();
            MesurementType type = new MesurementType("Леукоцити", 16000, 20000);
            cbMetrics.Items.Add(type);
            type = new MesurementType("Еритроцити", 4, 7);
            cbMetrics.Items.Add(type);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            if(addPatient.ShowDialog() == DialogResult.OK)
            {
                lbPatients.Items.Add(addPatient.Patient);
            }
        }

        private void btnAddMetric_Click(object sender, EventArgs e)
        {
            Measurement measurement = new Measurement((MesurementType)cbMetrics.SelectedItem, (int)nudValue.Value);
            patient = lbPatients.SelectedItem as Patient;
            patient.measurements.Add(measurement);
            update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbPatients.SelectedIndex != -1) { 
                if(MessageBox.Show("Дали си сигурен?", "бриши", MessageBoxButtons.YesNo) ==  DialogResult.Yes)
                {
                    lbPatients.Items.RemoveAt(lbPatients.SelectedIndex);
                    update();
                }
            }
        }

        public void update()
        {
           lbMetrics.Items.Clear();
            if(patient != null)
            {
                foreach (Measurement measurement in patient.measurements)
                {
                    lbMetrics.Items.Add(measurement);
                }
            }
        }

        private void lbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            patient = lbPatients.SelectedItem as Patient;
            update();
        }

        

        private void cbMetrics_SelectedIndexChanged(object sender, EventArgs e)
        {
            MesurementType type = cbMetrics.SelectedItem as MesurementType;
            if(type != null)
            {
                nudValue.Maximum = type.Max;
                nudValue.Minimum = type.Min;
            }
        }
    }
}
