using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            string nm = textBox1.Text;
            label2.Text="Your name is: " + nm;
        }
    }
}
