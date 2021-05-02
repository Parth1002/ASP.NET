using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DialogBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 OwnedForm2 = new Form2();
           this.AddOwnedForm(OwnedForm2);
            string txt = textBox1.Text;
            

            OwnedForm2.Show(); 
           
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            AcceptButton = button1;
            CancelButton = button2;
        }
    }
}
