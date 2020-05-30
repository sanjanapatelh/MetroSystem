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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new travel().Show();
            this.Hide();
        }

        private void metrocard_Click(object sender, EventArgs e)
        {
            new gocashless().Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            new admin().Show();
            this.Hide();
        }
    }
}
