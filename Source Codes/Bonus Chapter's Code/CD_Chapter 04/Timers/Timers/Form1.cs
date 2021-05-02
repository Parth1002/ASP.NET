using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Timers
{
    public partial class Form1 : Form
    {
        bool blnAlarm = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                DateTime alarmTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(textBox1.Text.Trim()), Convert.ToInt32(textBox2.Text.Trim()), Convert.ToInt32(textBox3.Text.Trim()));
                if (DateTime.Now > alarmTime && blnAlarm)
                {
                    Interaction.Beep();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                blnAlarm = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                blnAlarm = false;
            }
        }
    }
}
