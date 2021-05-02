using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Activation;
using SharedObject;
namespace WellKnownSingleCallClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SharedObject.SharedObject obj;
        private void Button1_Click(object sender, EventArgs e)
        {
            ChannelServices.RegisterChannel(new TcpChannel(), false);
            obj = (SharedObject.SharedObject)(Activator.GetObject(
             typeof(SharedObject.SharedObject),
             "tcp://localhost:8086/HiServerApp/HiServer"));
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.Greeting(TextBox1.Text);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                MessageBox.Show(obj.GetCount().ToString());
            }
        }
    }
}
