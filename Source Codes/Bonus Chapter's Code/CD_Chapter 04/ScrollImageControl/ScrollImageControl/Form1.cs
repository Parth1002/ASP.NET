using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScrollImageControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Scroll += new ScrollEventHandler(ScrollBars_Scroll);
            vScrollBar1.Scroll += new ScrollEventHandler(ScrollBars_Scroll);

        }

        private void ShowScrollBars()
        {
            vScrollBar1.Visible = true;
            hScrollBar1.Visible = true;
            if (pictureBox1.Height > pictureBox1.Image.Height)
            {
                vScrollBar1.Visible = false;
            }
            if (pictureBox1.Width > pictureBox1.Image.Width)
            {
                hScrollBar1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                hScrollBar1.Maximum = pictureBox1.Image.Width - pictureBox1.Width;
                vScrollBar1.Maximum = pictureBox1.Image.Height - pictureBox1.Height;
                ShowScrollBars();
            }

        }

        private void ScrollBars_Scroll(object sender, ScrollEventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.DrawImage(pictureBox1.Image, new Rectangle(0, 0, pictureBox1.Width -
             hScrollBar1.Height, pictureBox1.Height - vScrollBar1.Width), new
             Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox1.Width - hScrollBar1.Height,
             pictureBox1.Height - vScrollBar1.Width), GraphicsUnit.Pixel);

        }

    }
}
