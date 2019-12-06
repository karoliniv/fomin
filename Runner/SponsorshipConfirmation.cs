﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class SponsorshipConfirmation : Form
    {
        public SponsorshipConfirmation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Main()).ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Main()).ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan y = Program.x - DateTime.Now;
            label4.Text = y.Days.ToString() + " дней " + y.Hours.ToString() + " часов " + y.Minutes.ToString() + " минут до старта марафона!";

        }
    }
}
