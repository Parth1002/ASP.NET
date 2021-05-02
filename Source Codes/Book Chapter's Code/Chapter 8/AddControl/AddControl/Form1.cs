using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox NewTextBox = new TextBox();
            NewTextBox.Name = "MyTextBox";
            NewTextBox.Size = new Size(120, 20);
            NewTextBox.Location = new Point(100, 100);
            NewTextBox.Text = "Hello World of Coding";
            Controls.Add(NewTextBox);  

        }
    }
}
