using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScrollBarControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 100;
            hScrollBar1.SmallChange = 1;
            hScrollBar1.LargeChange = 10;
            hScrollBar2.Value = 20;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = "Scroll position: " + e.NewValue;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Location = new Point(e.NewValue * this.Size.Width / 100, label1.Location.Y);
            label1.Text = "Move to the desk!";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Location = new Point(label1.Location.X, e.NewValue * this.Size.Height / 100);
            label1.Text = "Move to the desk!";
        }
    }
}
