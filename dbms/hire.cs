﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project1
{
    public partial class hire : Form
    {
        public hire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admin().Show();
            this.Hide();
        }
    }
}
