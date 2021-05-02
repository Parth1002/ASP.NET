using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatusStripSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] str = textBox1.Text.Split(' ');
            toolStripStatusLabel1.Text = ("Words: " + str.Length + ", " + "Characters (with spaces): " + textBox1.TextLength);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            toolStripProgressBar1.Minimum = 1;
            toolStripProgressBar1.Maximum = 100000;
            toolStripProgressBar1.Value = 1;
            toolStripProgressBar1.Step = 1;
            for (x = 1; x < 100000; x++)
            {
                toolStripProgressBar1.PerformStep();
            }
            textBox1.Text = "Welcome to C# 2010";
        }

   }
}
