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
using System.Runtime.Serialization.Formatters;
using SharedObject;
using System.Collections;

namespace DBServer
{
    public partial class Form1 : Form
    {
        IChannel chan;
        IServerChannelSinkProvider SProvider;
        IClientChannelSinkProvider CProvider;
        System.Threading.Thread Thd;
        public Form1()
        {
            InitializeComponent();
        }
        private void Start()
        {
            try
            {
                IDictionary props = null;
                props = new Hashtable();
                props["port"] = TextBox2.Text;
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
                    chan = new TcpChannel(props, CProvider, SProvider);
                }
                else if (rbtnHttpChannel.Checked)
                {
                    chan = new HttpChannel(props, CProvider, SProvider);
                }
                ChannelServices.RegisterChannel(chan, false);
                if (rbtnWSingleCall.Checked)
                {
                    RemotingConfiguration.RegisterWellKnownServiceType(
                     typeof(SharedObject.SharedObject), "HiServerApp/HiServer",
                     WellKnownObjectMode.SingleCall);
                }
                else if (rbtnWSingleTon.Checked)
                {
                    RemotingConfiguration.RegisterWellKnownServiceType(
                     typeof(SharedObject.SharedObject), "HiServerApp/HiServer",
                     WellKnownObjectMode.Singleton);
                }
                else if (rbtnCActivated.Checked)
                {
                    RemotingConfiguration.RegisterActivatedServiceType(
                     typeof(SharedObject.SharedObject));
                }
                Thd = System.Threading.Thread.CurrentThread;
                txtStatusBar.Text = "Connected";
            }
            catch (Exception ex)
            {
                txtStatusBar.Text = ex.Message;
            }
        }
        private void ListServices()
        {
            lbServces.Items.Clear();
            foreach (IChannelReceiver chan in ChannelServices.RegisteredChannels)
            {
                lbServces.Items.Add(chan.ChannelName);
            }
            UpdateDesc();
        }
        private void UpdateDesc()
        {
            TextBox1.Text = "";
            if (lbServces.Items.Count > 0)
            {
                if (lbServces.SelectedItems.Count > 0)
                {
                    IChannelReceiver chan =
                     (IChannelReceiver)ChannelServices.GetChannel(
                     System.Convert.ToString(lbServces.SelectedItem));
                    string strDesc = null;
                    foreach (string UriName in
                     ((ChannelDataStore)chan.ChannelData).ChannelUris)
                    {
                        strDesc += UriName + System.Environment.NewLine;
                    }
                    TextBox1.Text = strDesc;
                    TextBox1.Text += "Priority : " + chan.ChannelPriority.ToString();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListServices();
        }
        private void btnStopSelected_Click(object sender, EventArgs e)
        {
            if (lbServces.Items.Count > 0)
            {
                if (lbServces.SelectedItems.Count > 0)
                {
                    IChannelReceiver chan =
                     (IChannelReceiver)ChannelServices.GetChannel(
                     System.Convert.ToString(lbServces.SelectedItem));
                    ChannelServices.UnregisterChannel(chan);
                    chan.StopListening(null);
                    ListServices();
                    txtStatusBar.Text = "Disconnected";
                }
            }
        }
        private void rbtnHttpChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHttpChannel.Checked)
            {
                rbtnSoap.Checked = true;
                GroupBox1.Enabled = false;
            }
        }
        private void rbtnTcpChannel_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
        }
        private void lbServces_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListServices();
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}
