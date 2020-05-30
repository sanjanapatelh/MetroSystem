using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project1
{
    public partial class checkbalance : Form
    {
        public checkbalance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new gocashless().Show();
            this.Hide();

        }
    }
}
