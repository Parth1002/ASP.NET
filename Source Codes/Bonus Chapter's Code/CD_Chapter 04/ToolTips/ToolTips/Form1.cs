using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolTips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "This is a button");
            toolTip1.InitialDelay = 8000;
            toolTip1.ReshowDelay = 110;
            toolTip1.AutoPopDelay = 1200;
            toolTip1.AutomaticDelay = 6000;

        }
    }
}
