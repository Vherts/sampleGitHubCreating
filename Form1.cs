﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleGitHubCreating
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Try me!", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Fuck me!", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click ( object sender, EventArgs e )
        {

        }
    }
}
