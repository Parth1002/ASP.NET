using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichTextBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Find("bold");
            Font boldFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionFont = boldFont;
            richTextBox1.SelectionStart = richTextBox1.Find("italic");
            Font italicFont = new Font(richTextBox1.Font, FontStyle.Italic);
            richTextBox1.SelectionFont = italicFont;
            richTextBox1.SelectionStart = richTextBox1.Find("underlined");
            Font underlineFont = new Font(richTextBox1.Font, FontStyle.Underline);
            richTextBox1.SelectionFont = underlineFont;
            richTextBox1.SelectionStart = richTextBox1.Find("strikeout");
            Font strikeoutFont = new Font(richTextBox1.Font, FontStyle.Strikeout);
            richTextBox1.SelectionFont = strikeoutFont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Rtf = richTextBox1.Rtf;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 20;
            richTextBox1.SelectionHangingIndent = -25;
            richTextBox1.SelectionRightIndent = 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 20;
            richTextBox1.BulletIndent = 10;
            richTextBox1.SelectionBullet = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox3.SelectionStart = richTextBox3.Find("Green");
            richTextBox3.SelectionColor = Color.Green;
            richTextBox3.SelectionStart = richTextBox3.Find("Brown");
            richTextBox3.SelectionColor = Color.Brown;
            richTextBox3.SelectionStart = richTextBox3.Find("Pink");
            richTextBox3.SelectionColor = Color.Pink;
        }

    }
}
