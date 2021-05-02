using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericDictionarySample
{
	public partial class Form1 : Form
	{
		Dictionary<int, string> DictStr = new Dictionary<int, string>();
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			button2.Enabled = false;
			button3.Enabled = false;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			DictStr.Add(100, "White");
			DictStr.Add(101, "Black");
			DictStr.Add(102, "Blue");
			DictStr.Add(103, "Yellow");
			DictStr.Add(104, "Green");
			DictStr.Add(105, "Red");
			DictStr.Add(106, "Orange");
			DictStr.Add(107, "Purple");
			DictStr.Add(108, "Magenta");
			DictStr.Add(109, "Brown");
			LoadDictionary();
			button2.Enabled = true;
			button3.Enabled = true;
		}
		private void LoadDictionary()
		{
			listView1.Items.Clear();
			foreach (object obj in DictStr.Keys)
			{
                ListViewItem lItem = listView1.Items.Add(obj.ToString());
				lItem.SubItems.Add(DictStr[(int)obj]);
			}
		}
private void button2_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the key to look up",  "", "", -1, -1);
	if (DictStr.ContainsKey(Convert.ToInt32(tempKey)))
	{
		MessageBox.Show("The dictionary contains the specified key");
	}
	else
	{
		MessageBox.Show("The dictionary does not contain the specified key");
	}
}
private void button3_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the value to look  up", "", "", -1, -1);
	if (DictStr.ContainsValue(tempKey))
	{
		MessageBox.Show("The dictionary contains the specified value");
	}
	else
	{
		MessageBox.Show("The dictionary does not contain the specified value");
	}
}

	}
}
