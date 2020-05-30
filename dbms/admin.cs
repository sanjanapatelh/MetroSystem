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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new getdetails().Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void hire_Click(object sender, EventArgs e)
        {
            new hire().Show();
            this.Hide();
        }

        private void fire_Click(object sender, EventArgs e)
        {
            new fire().Show();
            this.Hide();
        }
    }
}
