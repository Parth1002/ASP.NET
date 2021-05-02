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

namespace DecompressingFiles
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
                GZipStream gzDecompressed;
                fsSource = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                gzDecompressed = new GZipStream(fsSource, CompressionMode.Decompress, true);
                bufferWrite = new byte[4];
                fsSource.Position = (int)fsSource.Length - 4;
                fsSource.Read(bufferWrite, 0, 4);
                fsSource.Position = 0;
                int bufferLength = BitConverter.ToInt32(bufferWrite, 0);
                byte[] buffer = new byte[bufferLength + 100];
                int readOffset = 0;
                int totalBytes = 0;
                while (true)
                {
                    int bytesRead = gzDecompressed.Read(buffer, readOffset, 100);
                    if (bytesRead == 0)
                        break;
                    readOffset += bytesRead;
                    totalBytes += bytesRead;
                }
                fsDest = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                fsDest.Write(buffer, 0, totalBytes);
                fsSource.Close();
                gzDecompressed.Close();
                fsDest.Close();
            }
        }

    }
}

