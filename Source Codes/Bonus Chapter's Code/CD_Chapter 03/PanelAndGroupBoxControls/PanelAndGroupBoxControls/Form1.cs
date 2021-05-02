using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PanelAndGroupBoxControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "You have clicked radio button 1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "You have clicked radio button 2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "You have clicked radio button 3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "You have clicked radio button 4";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "You have clicked radio button 5";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "You have clicked radio button 6";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             panel1.BorderStyle = BorderStyle.Fixed3D;
             panel1.AutoScroll = true;
           
        }
    }
}
