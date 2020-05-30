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
    public partial class gocashless : Form
    {
        public gocashless()
        {
            InitializeComponent();
        }

        private void gocashless_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new checkbalance().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new getnewcard().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
       
        private void logo_Click(object sender, EventArgs e)
        {
          new main().Show();
            this.Hide();
        }

        private void recharge_Click(object sender, EventArgs e)
        {
            new recharge().Show();
            this.Hide();
        }
        
    }
}
