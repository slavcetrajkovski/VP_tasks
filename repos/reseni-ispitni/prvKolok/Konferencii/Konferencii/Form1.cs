using Konferencii;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferencePapers
{
    public partial class Form1 : Form
    {
        List<Conference> Conferences;
        Conference selectedConference;
        int selectedYear;
        public Form1()
        {
            InitializeComponent();
            Conferences = new List<Conference>();
            Conference c = new Conference("ICT Innovation", 2014);
            Conferences.Add(c);
            c = new Conference("ICT Innovation", 2013);
            Conferences.Add(c);
            c = new Conference("ADBIS", 2014);
            Conferences.Add(c);
            c = new Conference("CIIT", 2013);
            Conferences.Add(c);
            c = new Conference("CIIT", 2012);
            Conferences.Add(c);
            selectedYear = -1;
            loadConferences(selectedYear);
            loadYears();
        }

        private void btnAddConf_Click(object sender, EventArgs e)
        {
            AddConference cf = new AddConference();
            if (cf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Conferences.Add(cf.conference);
                loadConferences(selectedYear);
                loadYears();
            }
        }

        private void loadConferences(int year)
        {
            lbConference.Items.Clear();
            foreach (Conference c in Conferences)
            {
                if (year == -1 || c.Year == year)
                {
                    lbConference.Items.Add(c);
                }
            }
        }


        private void loadYears()
        {
            cbYear.Items.Clear();
            cbYear.Items.Add(-1);
            foreach (Conference c in Conferences)
            {
                if (!cbYear.Items.Contains(c.Year))
                {
                    cbYear.Items.Add(c.Year);
                }
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYear = (int)cbYear.SelectedItem;
            loadConferences(selectedYear);
        }


        private void lbConferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbConference.SelectedIndex != -1)
            {
                selectedConference = lbConference.SelectedItem as Conference;
            }
            else
            {
                selectedConference = null;
            }
        }

        private void btnCancelConf_Click(object sender, EventArgs e)
        {
            if (lbConference.SelectedIndex == -1) return;
            if (MessageBox.Show("Дали сте сигурни?", "Избриши конференција?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                List<Conference> filtered = new List<Conference>();
                foreach (Conference c in Conferences)
                {
                    if (c.Id != selectedConference.Id)
                    {
                        filtered.Add(c);
                    }
                }
                Conferences = filtered;
                loadConferences(selectedYear);
            }
        }
    }
}
