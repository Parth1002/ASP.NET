using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace SelfHostedService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaring an object of the ServiceHost class
        ServiceHost myServiceHost;

        private void Form1_Load(object sender, EventArgs e)
        {
            myServiceHost = new ServiceHost(typeof(UpperCaseService));
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opening the ServiceHost object to listen to messages
            myServiceHost.Open();
            label1.Text = "The UpperCaseService service is now ";
            label2.Text = "Open";
            button2.Enabled = true;
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the ServiceHost object
            myServiceHost.Close();
            label1.Text = "The UpperCaseService service is now";
            label2.Text = "Closed";
            button1.Enabled = true;
            button2.Enabled = false; 

        }
    }
}
