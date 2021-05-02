using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BinaryReadWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream mystream = File.Create("D:\\test.dat");
            BinaryWriter writer = new BinaryWriter(mystream);
            int x = 10;
            decimal d = 9.126M;
            string str = "Hello World";
            writer.Write(x);
            writer.Write(d);
            writer.Write(str);
            writer.Close();
            mystream.Close();
            MessageBox.Show("Binary data is written in D:\\test.dat");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead("D:\\test.dat");
            BinaryReader br = new BinaryReader(fs);
            MessageBox.Show(br.ReadInt32().ToString());
            MessageBox.Show(br.ReadDecimal().ToString());
            MessageBox.Show(br.ReadString());
        }
    }
}
