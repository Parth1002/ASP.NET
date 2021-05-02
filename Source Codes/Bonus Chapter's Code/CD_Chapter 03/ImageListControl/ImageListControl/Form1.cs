using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageListControl
{
    public partial class Form1 : Form
    {
        private int ImageIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[ImageIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ImageIndex < imageList1.Images.Count - 1)
            {
                ImageIndex += 1;
            }
            else
            {
                ImageIndex = 0;
            }
            pictureBox1.Image = imageList1.Images[ImageIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileNames != null)
                {
                    int intLoopIndex;
                    for (intLoopIndex = 0; intLoopIndex < openFileDialog1.FileNames.Length; intLoopIndex++)
                    {
                        imageList1.Images.Add(Image.FromFile(openFileDialog1.FileNames[intLoopIndex]));
                    }
                }
                else
                {
                    imageList1.Images.Add(Image.FromFile(openFileDialog1.FileNames[Convert.ToInt32(openFileDialog1.FileName)]));
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ClientSize = new Size(300, 150);

        }

    }
}
