using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SharedObject;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Microsoft.DirectX;


namespace WellKnownSingleTonClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private Pen MyPen;
        private Point last;
        private Point down;
        private Graphics g;
        private Point[] Points;
        private int NumberPoints = 0;
        private bool bConnected = false;
        private IChannel chan;
        private IServerChannelSinkProvider SProvider;
        private IClientChannelSinkProvider CProvider;
        private IDictionary props;
        private SharedObject.SharedObject Obj;
        public EventSink sink;

     

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                last = new Point(e.X, e.Y);
                Array.Resize(ref Points, NumberPoints + 1);
                Points[NumberPoints] = last;
                NumberPoints += 1;
                if (NumberPoints >= 2)
                {
                    try
                    {
                        if (bConnected)
                        {
                            Obj.Confer(down, last);
                        }
                    }
                    catch (Exception ex)
                    {
                        txtStatusBar.Text = ex.Message;
                    }
                    g.DrawLine(MyPen, down, last);
                }
                down = last;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = Panel1.CreateGraphics();
            MyPen = new Pen(Color.Black, 5F);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (NumberPoints >= 2)
            {
                g.DrawLines(MyPen, Points);
            }

        }

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
                    URI = "tcp://" + TextBox1.Text + ":" + TextBox2.Text +
                    "/HiServerApp/HiServer";
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
                    URI = "http://" + TextBox1.Text + ":" + TextBox2.Text +
                     "/HiServerApp/HiServer";
                }
                ChannelServices.RegisterChannel(chan, false);
                Obj = (SharedObject.SharedObject)(Activator.GetObject(
                 typeof(SharedObject.SharedObject), URI));
                if (cbtnFullTrust.Checked)
                {
                    StrokeEvent DrLn = new StrokeEvent(this.DrawLine);
                    sink = new EventSink(DrLn);
                    Obj.Stroke += new StrokeEvent(sink.OnStroke);
                }
                bConnected = true;
                txtStatusBar.Text = "Connected";
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
        public delegate int GetCount();
        public void DrawLine(Point from, Point Till)
        {
            g.DrawLine(Pens.Red, from, Till);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MyPen.Color = colorDialog1.Color;
                Button6.ForeColor = colorDialog1.Color;
                Button6.BackColor = Microsoft.DirectX.Direct3D.ColorOperator.Negative(colorDialog1.Color);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (NumberPoints > 0)
            {
                System.Array.Clear(Points, 0, NumberPoints);
                NumberPoints = 0;
            }
            Panel1.Invalidate();

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (NumberPoints > 0)
            {
                System.Array.Clear(Points, 0, NumberPoints);
                NumberPoints = 0;
            }

        }

        private void rbtnTcpChannel_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox4.Enabled = true;
        }

        private void rbtnHttpChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHttpChannel.Checked)
            {
                rbtnSoap.Checked = true;
                GroupBox4.Enabled = false;
            }

        }

      
        private void Button3_Click(object sender, EventArgs e)
        {
            if (bConnected)
            {
                GetCount GetC = new GetCount(Obj.GetCount);
                IAsyncResult ar = GetC.BeginInvoke(null, null);
                ar.AsyncWaitHandle.WaitOne();
                if (ar.IsCompleted)
                {
                    MessageBox.Show(GetC.EndInvoke(ar).ToString());
                }
            }

        }

        private void Button5_Click(object sender, EventArgs e)
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
    }
}
