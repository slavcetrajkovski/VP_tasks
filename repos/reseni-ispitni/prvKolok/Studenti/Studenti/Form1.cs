using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGenerate.Enabled = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            if (newStudent.ShowDialog() == DialogResult.OK)
            {
                lbStudents.Items.Add(newStudent.student);
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedIndex != -1)
            {
                File file = new File((int)nudSubjects.Value);
                Random random = new Random();
                lbSubjects.Items.Clear();
                for (int i = 1; i <= file.Subject; i++)
                {
                    Student students = lbStudents.SelectedItem as Student;
                    File f = new File(i);
                    f.Grade = random.Next(6, 11);
                    students.Files.Add(f);
                }
                generateStudent();
                maxAverage();
            }
        }

        private void generateStudent()
        {
            lbSubjects.Items.Clear();
            if (lbStudents.SelectedIndex != -1)
            {
                Student students = lbStudents.SelectedItem as Student;
                foreach (File f in students.Files)
                {
                    lbSubjects.Items.Add(f);
                }
                tbAverage.Text = string.Format("{0:0.00}", students.average());
            }  
        }

        private void maxAverage()
        {
                double max = -1;
                for (int i = 0; i < lbStudents.Items.Count; i++)
                {
                    Student s = lbStudents.Items[i] as Student;
                    if (s.average() > max)
                    {
                        max = s.average();
                    }
                }
                tbHighestAverage.Text = string.Format("{0:0.00}", max);
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerate.Enabled = true;
            generateStudent();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if(lbStudents.SelectedIndex != -1) 
            {
                if(MessageBox.Show("Дали сте сигурни?", "избриши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbStudents.Items.RemoveAt(lbStudents.SelectedIndex);
                    tbAverage.Clear();
                    lbSubjects.Items.Clear();
                    maxAverage();
                }
            }
        }
    }
}
