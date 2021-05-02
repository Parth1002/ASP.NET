using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransactionComponent;

namespace ServicesWithoutComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionClass trans = new TransactionClass();
            MessageBox.Show(trans.AddDetails("Table Lamp", "A table lamp with the picture of flowers", "Show piece"));

        }
    }
}
