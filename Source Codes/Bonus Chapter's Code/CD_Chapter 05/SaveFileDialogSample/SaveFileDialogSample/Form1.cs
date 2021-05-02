using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaveFileDialogSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText(saveFileDialog1.FileName,
                 textBox1.Text, true);
            }
        }
    }
}
