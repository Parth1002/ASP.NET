using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericSortedDictionarySample
{
	public partial class Form1 : Form
	{
		SortedDictionary<int, string> SDictStr = new SortedDictionary<int, string>();
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
			SDictStr.Add(100, "White");
			SDictStr.Add(101, "Black");
			SDictStr.Add(102, "Blue");
			SDictStr.Add(103, "Yellow");
			SDictStr.Add(104, "Green");
			SDictStr.Add(105, "Red");
			SDictStr.Add(106, "Orange");
			SDictStr.Add(107, "Purple");
			SDictStr.Add(108, "Magenta");
			SDictStr.Add(109, "Brown");
			LoadSrtdDictionary();
			button2.Enabled = true;
			button3.Enabled = true;
		}
		private void LoadSrtdDictionary()
		{
			listView1.Items.Clear();
			foreach (object obj in SDictStr.Keys)
			{
				ListViewItem lItem = listView1.Items.Add(obj.ToString());
				lItem.SubItems.Add(SDictStr[(int)obj]);
			}
		}
private void button2_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the key to look up",  "", "", -1, -1);
	if (SDictStr.ContainsKey(Convert.ToInt32(tempKey)))
	{
		MessageBox.Show("The sorted dictionary contains the specified key");
	}
	else
	{
		MessageBox.Show("The sorted dictionary does not contain the specified key");
	}
}
private void button3_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the value to look  up", "", "", -1, -1);
	if (SDictStr.ContainsValue(tempKey))
	{
		MessageBox.Show("The sorted dictionary contains the specified value");
	}
	else
	{
		MessageBox.Show("The sorted dictionary does not contain the specified value");
	}
}   
	}
}
