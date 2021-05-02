using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intLoopIndex = 0;
            for (intLoopIndex = 1; intLoopIndex <= 20; intLoopIndex++)
            {
                listBox1.Items.Add("Item " + intLoopIndex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intLoopIndex = 0;
            for (intLoopIndex = 0; intLoopIndex < listBox1.Items.Count; intLoopIndex++)
            {
                listBox2.Items.Add("Index " + intLoopIndex.ToString());
            }
            label1.Text = "Total number of items : " + listBox1.Items.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "The selected item : " + listBox1.SelectedItem.ToString() + " has an index : " + listBox1.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.MultiColumn = true;
            listBox1.MultiColumn = true;
            listBox1.SelectionMode = SelectionMode.MultiExtended;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "Selected items: ";
            foreach (var Item in listBox1.SelectedItems)
            {
                textBox1.Text += Item.ToString() + " ";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove("Item 6");
            listBox1.Items.RemoveAt(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
    }
}
