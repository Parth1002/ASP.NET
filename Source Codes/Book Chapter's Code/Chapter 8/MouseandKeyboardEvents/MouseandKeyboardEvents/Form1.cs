using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseandKeyboardEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            textBox1.ForeColor = Color.White;

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Enter only numbers.");
                textBox1.Text = "";
            }
         
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            textBox2.ForeColor = Color.White;

        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Enter only numbers.");
                textBox2.Text = "";
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total is " + (Convert.ToInt32(textBox1.Text) +
    Convert.ToInt32(textBox2.Text)));

        }
    }
}
