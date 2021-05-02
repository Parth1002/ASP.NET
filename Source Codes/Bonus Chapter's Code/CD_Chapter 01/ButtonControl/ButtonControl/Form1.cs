using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "jay goga";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Click Me";
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse move event calling");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("jay goga");
        }
    }
}
