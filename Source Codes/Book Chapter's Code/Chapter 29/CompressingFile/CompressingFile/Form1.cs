using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace CompressingFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] bufferWrite;
                FileStream fsSource;
                FileStream fsDest;
                GZipStream gzCompressed;
                fsSource = new FileStream(textBox1.Text, FileMode.Open,FileAccess.Read, FileShare.Read);
                bufferWrite = new byte[fsSource.Length];
                fsSource.Read(bufferWrite, 0, bufferWrite.Length);
                fsDest = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate,FileAccess.Write);
                gzCompressed = new GZipStream(fsDest, CompressionMode.Compress,true);
                gzCompressed.Write(bufferWrite, 0, bufferWrite.Length);
                fsSource.Close();
                gzCompressed.Close();
                fsDest.Close();
            }
        }
    }
}
