using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "tabPage3";
            tabControl1.TabPages.Add(tabpage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button3 = new Button();
            button3.Click += new System.EventHandler(button3_Click);
            button3.Size = new Size(112, 23);
            button3.Location = new Point(18, 75);
            button3.Text = "New Button";
            tabControl1.TabPages[0].Controls.Add(button3);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

    }
}
