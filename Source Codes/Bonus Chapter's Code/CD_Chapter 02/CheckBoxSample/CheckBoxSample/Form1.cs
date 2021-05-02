using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckBoxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Text = "Chars count";
            checkBox2.Text = "Words count";
            checkBox3.Text = "Check box displaying indeterminate state";

            checkBox1.Checked = true;
            textBox1.Text = "Welcome to Visual C# 2010";
            label1.Text = "Total characters : " + textBox1.TextLength;
            checkBox3.CheckState = CheckState.Indeterminate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wrdcount = 0;
            int chrcount = 0;
            label1.Text = "";
            checkBox3.Checked = false;
            if (checkBox1.Checked == true)
            {
                chrcount = textBox1.Text.Length;
                label1.Text = "Total characters : " + chrcount;
            }

            if (checkBox2.Checked == true)
            {
                if (textBox1.Text.Trim().Length == 0)
                {
                    label1.Text = label1.Text + " " + "Total words : 0";
                }
                else
                {
                    string[] str = textBox1.Text.Split(' ');
                    wrdcount = str.Length;
                    label1.Text = label1.Text + " " + "Total words : " + wrdcount;
                }
            }


            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                checkBox3.Checked = true;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                checkBox3.Checked = false;
            }

            if ((checkBox1.Checked == false && checkBox2.Checked == true) || (checkBox1.Checked == true && checkBox2.Checked == false))
            {
                checkBox3.CheckState = CheckState.Indeterminate;
            }


        }
    }
}
