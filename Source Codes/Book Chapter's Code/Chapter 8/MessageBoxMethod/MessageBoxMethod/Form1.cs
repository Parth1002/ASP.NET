using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg=textBox1.Text;
            int Result = 0;
            Result = ((int)MessageBox.Show("This is a message box!\nYour text is : "+msg, "Message Box",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly));
            if (Result == (int)DialogResult.OK)
            {
                textBox1.Text = "You clicked OK";
            }

        }
    }
}
