using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimePickerControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = "Day of the month selected: " + monthCalendar1.SelectionRange.Start.Day;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2010, 10, 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd hh:mm:ss tt";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;

        }
    }
}
