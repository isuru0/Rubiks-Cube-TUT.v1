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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form01().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form02().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form03().Show();
            this.Hide();
        }
            

        private void button4_Click(object sender, EventArgs e)
        {

            //this.Close();

            System.Windows.Forms.Application.ExitThread();
        }

    }
}
