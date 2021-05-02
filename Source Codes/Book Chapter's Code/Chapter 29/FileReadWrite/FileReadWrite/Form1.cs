using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileReadWrite
{
    public partial class Form1 : Form
    {
        StreamWriter sw = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"D:\\File.txt");
            FileStream fstr = fi.Create();
            fstr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Open("D:\\File.txt", FileMode.Append,FileAccess.Write);
            sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            string sInput = "The quick brown fox jumps over the lazy little dog.";
            sw.WriteLine(sInput);
            sw.Close();
            sw = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader s = File.OpenText("D:\\File.txt");
            richTextBox1.Text = s.ReadToEnd();
            s.Close();
        }
    }
}
