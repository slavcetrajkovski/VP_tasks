using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispiti
{
    public partial class Form1 : Form
    {
        Exam selectedExam;
        public Form1()
        {
            InitializeComponent();
            Exam exam = new Exam("Јуни", 2014);
            lbExams.Items.Add(exam);
            exam = new Exam("Август", 2013);
            lbExams.Items.Add(exam);
            exam = new Exam("Јануари", 2015);
            lbExams.Items.Add(exam);
            exam = new Exam("Јуни", 2013);
            lbExams.Items.Add(exam);
            exam = new Exam("Август", 2012);
            lbExams.Items.Add(exam);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddExam ae = new AddExam();
            if(ae.ShowDialog() == DialogResult.OK)
            {
                lbExams.Items.Add(ae.exam);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbExams.SelectedIndex != -1)
            {
                if(MessageBox.Show("Дали сте сигурни?", "Избриши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbExams.Items.RemoveAt(lbExams.SelectedIndex);
                    tbDesc1.Clear();
                    tbDesc2.Clear();
                    nudPoints1.ResetText();
                    nudPoints2.ResetText();
                }
            }
        }

        private void lbExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = lbExams.SelectedIndex != -1;
            if(lbExams.SelectedIndex != -1)
            {
                selectedExam = lbExams.SelectedItem as Exam;
                tbDesc1.Text = selectedExam.Problem1.Description;
                nudPoints1.Value = selectedExam.Problem1.Points;
                tbDesc2.Text = selectedExam.Problem2.Description;
                nudPoints2.Value = selectedExam.Problem2.Points;
            }
            else
            {
                selectedExam = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(selectedExam == null)
            {
                return;
            }
            selectedExam.Problem1.Description = tbDesc1.Text;
            selectedExam.Problem1.Points = (int) nudPoints1.Value;
            MessageBox.Show("Зачувано!");
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (selectedExam == null)
            {
                return;
            }
            selectedExam.Problem2.Description = tbDesc2.Text;
            selectedExam.Problem2.Points = (int)nudPoints2.Value;
            MessageBox.Show("Зачувано!");
        }
    }
}
