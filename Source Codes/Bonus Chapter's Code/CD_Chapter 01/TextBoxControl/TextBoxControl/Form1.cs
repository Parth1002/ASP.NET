using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' | e.KeyChar > '9')
            {
                MessageBox.Show("Please enter only digits!");
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int z;
            for (int i = 1; i <= 10; i++)
            {
                z = x * i;
                textBox2.AppendText(x + " * " + i + " = " + z.ToString() + "\n");
            }
        }
    }
}
