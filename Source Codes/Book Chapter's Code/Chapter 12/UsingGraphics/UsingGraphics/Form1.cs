using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Tomato, 2);
            g.DrawEllipse(pen, 150, 25, 50, 50);
            g.DrawEllipse(pen, 160, 35, 10, 10);
            g.DrawEllipse(pen, 180, 35, 10, 10);
            g.DrawArc(pen, 150, 35, 50, 30, 45, 90);
            g.DrawRectangle(pen, 150, 75, 50, 100);
            g.DrawLine(pen, 175, 175, 150, 250);
            g.DrawLine(pen, 175, 175, 200, 250);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Teal);
            g.FillEllipse(myBrush, 150, 25, 50, 50);
            myBrush.Color = Color.Black;
            g.FillEllipse(myBrush, 160, 35, 10, 10);
            g.FillEllipse(myBrush, 180, 35, 10, 10);
            myBrush.Color = Color.Black;
            g.FillPie(myBrush, 150, 35, 50, 30, 45, 90);
            myBrush.Color = Color.GreenYellow;
            g.FillRectangle(myBrush, 150, 75, 50, 100);

        }
    }
}
