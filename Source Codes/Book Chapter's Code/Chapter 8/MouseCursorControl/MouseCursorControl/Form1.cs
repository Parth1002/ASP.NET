using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseCursorControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Help;
            button1.Cursor = Cursors.SizeAll;
            checkBox1.Cursor = Cursors.SizeNESW;
            textBox1.Cursor = Cursors.AppStarting;

        }
    }
}
