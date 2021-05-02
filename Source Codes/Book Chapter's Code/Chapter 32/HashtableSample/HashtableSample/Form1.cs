using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HashtableSample
{
    public partial class Form1 : Form
    {
        private Hashtable HTbl;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HTbl = new Hashtable(10);
			HTbl.Add(100, "White");
			HTbl.Add(101, "Black");
			HTbl.Add(102, "Blue");
			HTbl.Add(103, "Yellow");
			HTbl.Add(104, "Green");
			HTbl.Add(105, "Red");
			HTbl.Add(106, "Orange");
			HTbl.Add(107, "Purple");
			HTbl.Add(108, "Magenta");
			HTbl.Add(109, "Brown");
			LoadHshTable();
			button2.Enabled = true;
			button3.Enabled = true;
		}
            private void Form1_Load(object sender, EventArgs e)
        {
    		button2.Enabled = false;
			button3.Enabled = false;
		}
		private void LoadHshTable()
		{
			listView1.Items.Clear();
			foreach (object obj in HTbl.Keys)
			{
				ListViewItem lItem = listView1.Items.Add(obj.ToString());
				lItem.SubItems.Add(HTbl[obj].ToString());
			}            
		}
private void button2_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the key to look up",  "", "", -1, -1);
	if (HTbl.ContainsKey(Convert.ToInt32(tempKey))) {
		MessageBox.Show("The hashtable contains the specified key");
	}
	else
	{
		MessageBox.Show("The hashtable does not contain the specified key");
	}
}
private void button3_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the value to look up", "", "", -1, -1);
	if (HTbl.ContainsValue(tempKey))
	{
		MessageBox.Show("The hashtable contains the specified value");
	}
	else
	{
		MessageBox.Show("The hashtable does not contain the specified value");
	}
}

    }
}
