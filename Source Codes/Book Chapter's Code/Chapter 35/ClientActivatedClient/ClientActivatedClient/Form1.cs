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
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using SharedObject;

namespace ClientActivatedClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TimeSpan TimeSp = new TimeSpan(0);
        private bool bConnected = false;
        private IChannel chan;
        private IServerChannelSinkProvider SProvider;
        private IClientChannelSinkProvider CProvider;
        private IDictionary props;
        private SharedObject.SharedObject Obj;
        public EventSink sink;
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string URI = null;
                IDictionary props = null;
                props = new Hashtable();
                props["port"] = "0";
                if (rbtnBinary.Checked)
                {
                    SProvider = new BinaryServerFormatterSinkProvider();
                    CProvider = new BinaryClientFormatterSinkProvider();
                    if (cbtnFullTrust.Checked)
                    {
                        ((BinaryServerFormatterSinkProvider)SProvider).TypeFilterLevel =
                         TypeFilterLevel.Full;
                    }
                }
                else if (rbtnSoap.Checked)
                {
                    SProvider = new SoapServerFormatterSinkProvider();
                    CProvider = new SoapClientFormatterSinkProvider();
                    if (cbtnFullTrust.Checked)
                    {
                        ((SoapServerFormatterSinkProvider)SProvider).TypeFilterLevel =
                         TypeFilterLevel.Full;
                    }
                }
                if (rbtnTcpChannel.Checked)
                {
                    if (!cbtnFullTrust.Checked)
                    {
                        chan = new TcpChannel();
                    }
                    else
                    {
                        chan = new TcpChannel(props, CProvider, SProvider);
                    }
                    URI = "tcp://localhost:" + TextBox2.Text;
                }
                else if (rbtnHttpChannel.Checked)
                {
                    if (!cbtnFullTrust.Checked)
                    {
                        chan = new HttpChannel();
                    }
                    else
                    {
                        chan = new HttpChannel(props, CProvider, SProvider);
                    }
                    URI = "http://localhost:" + TextBox2.Text;
                }
                ChannelServices.RegisterChannel(chan, false);
                RemotingConfiguration.RegisterActivatedClientType(
                 typeof(SharedObject.SharedObject), URI);
                Obj = new SharedObject.SharedObject();
                if (cbtnFullTrust.Checked)
                {
                    MessageBox.Show("FullTrust");
                    StatusEvent StMtd = new StatusEvent(this.StausMethod);
                    sink = new EventSink(StMtd);
                    Obj.Status += new StatusEvent(sink.OnStatus);
                }
                txtStatusBar.Text = "Connected";
                bConnected = true;
            }
            catch (Exception ex)
            {
                txtStatusBar.Text = ex.Message;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (bConnected)
            {
                Obj.Greeting(TextBox1.Text);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (bConnected)
            {
                MessageBox.Show(Obj.GetCount().ToString());
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (chan != null)
            {
                ChannelServices.UnregisterChannel(chan);
                SProvider = null;
                CProvider = null;
                chan = null;
                Obj = null;
                bConnected = false;
                txtStatusBar.Text = "Disconnected";
            }
        }
        public void StausMethod(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }
        private void rbtnTcpChannel_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
        }
        private void rbtnHttpChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHttpChannel.Checked)
            {
                rbtnSoap.Checked = true;
                GroupBox1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSp.Add(TimeSpan.FromSeconds(1));
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (bConnected)
            {
                Obj.ClimbTheCliff();
                System.Diagnostics.Debug.WriteLine("Call Complete");
            }
        }
    }
}
