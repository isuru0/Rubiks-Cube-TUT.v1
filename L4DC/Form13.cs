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
    public partial class Forms4 : Form
    {
        public Forms4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form021().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form01().Show();
        }
    }
}
