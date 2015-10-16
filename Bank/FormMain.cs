﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBalance formBalance = new FormBalance();
            formBalance.MdiParent = this;
            formBalance.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to quit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void balanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBalance formBalance = new FormBalance();
            formBalance.MdiParent = this;
            formBalance.Show();
        }

        private void balanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDeposit formDeposit = new FormDeposit();
            formDeposit.MdiParent = this;
            formDeposit.Show();
        }
    }
}
