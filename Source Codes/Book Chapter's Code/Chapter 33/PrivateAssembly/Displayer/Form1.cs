using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Displayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PrivateAssembly.Class1 c1 = new PrivateAssembly.Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            c1.Display("Hello from Visual C#!");
        }
    }
}
