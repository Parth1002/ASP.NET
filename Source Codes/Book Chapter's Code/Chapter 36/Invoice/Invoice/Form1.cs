using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace Invoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ElementHost eh = new ElementHost();
            MyLogo.UserControl1 uc1 = new MyLogo.UserControl1();
            eh.Child = uc1;
            eh.Height = eh.Width = 30;
            panel1.Controls.Add(eh);
        }
    }
}
