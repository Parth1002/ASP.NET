using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form2 : Form
    {
        private string strMessage;
        public string Message
        {
            get
            {
                return strMessage;
            }
            set
            {
                strMessage = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Message != null)
            textBox1.Text = Message;
        }
    }
}
