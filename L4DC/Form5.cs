using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L4DC
{
    public partial class Form021 : Form
    {
        public Form021()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form02().Show();
            this.Hide();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Forms11().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Forms12().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Forms31().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Forms32().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Forms21().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Forms22().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Forms4().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Forms5().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Forms6().Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Forms71().Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Forms72().Show();
            this.Hide();
        }
    }
}
