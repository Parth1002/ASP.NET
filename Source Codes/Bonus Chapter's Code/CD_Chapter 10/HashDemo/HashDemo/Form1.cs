using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] hashValue, MessageBytes;
        string StringtoConvert;
        UnicodeEncoding MyUniCodeEncoding;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            StringtoConvert = textBox1.Text;
            MyUniCodeEncoding = new UnicodeEncoding();
            MessageBytes = MyUniCodeEncoding.GetBytes(StringtoConvert);
            SHA1Managed SHhash = new SHA1Managed();
            hashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in hashValue)
            {
                textBox2.Text = textBox2.Text + string.Format("{0:X2}", b);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            StringtoConvert = textBox1.Text;
            MyUniCodeEncoding = new UnicodeEncoding();
            MessageBytes = MyUniCodeEncoding.GetBytes(StringtoConvert);
            SHA256Managed SHhash = new SHA256Managed();
            hashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in hashValue)
            {
                textBox2.Text = textBox2.Text + string.Format("{0:X2}", b);
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            StringtoConvert = textBox1.Text;
            MyUniCodeEncoding = new UnicodeEncoding();
            MessageBytes = MyUniCodeEncoding.GetBytes(StringtoConvert);
            SHA384Managed SHhash = new SHA384Managed();
            hashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in hashValue)
            {
                textBox2.Text = textBox2.Text + string.Format("{0:X2}", b);
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            StringtoConvert = textBox1.Text;
            MyUniCodeEncoding = new UnicodeEncoding();
            MessageBytes = MyUniCodeEncoding.GetBytes(StringtoConvert);
            SHA512Managed SHhash = new SHA512Managed();
            hashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in hashValue)
            {
                textBox2.Text = textBox2.Text + string.Format("{0:X2}", b);
            }

        }

    }
}
