using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "Left";
            radioButton2.Text = "Center";
            radioButton3.Text = "Right";
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("The Radio Button Left is selected.");
            }
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("The Radio Button Center is selected.");
            }
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("The Radio Button Right is selected.");
            }

            radioButton1.Appearance = Appearance.Button;
            radioButton2.Appearance = Appearance.Button;
            radioButton3.Appearance = Appearance.Button;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(26, 63);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(155, 63);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(295, 63);
        }
    }
}