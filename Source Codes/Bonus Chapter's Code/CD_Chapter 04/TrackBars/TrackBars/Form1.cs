using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrackBars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar1.Maximum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar1.Minimum.ToString());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "Track bar value: " + trackBar1.Value;
        }
    }
}
