using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenFileDialogSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = "D:\\Pictures";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
    }
}
