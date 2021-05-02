using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericSortedListSample
{
	public partial class Form1 : Form
	{
		SortedList<int, string> SListStr = new SortedList<int, string>();
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
			SListStr.Add(100, "White");
			SListStr.Add(101, "Black");
			SListStr.Add(102, "Blue");
			SListStr.Add(103, "Yellow");
			SListStr.Add(104, "Green");
			SListStr.Add(105, "Red");
			SListStr.Add(106, "Orange");
			SListStr.Add(107, "Purple");
			SListStr.Add(108, "Magenta");
			SListStr.Add(109, "Brown");
			LoadSrtList();
			button2.Enabled = true;
			button3.Enabled = true;
		}
		private void LoadSrtList()
		{
			listView1.Items.Clear();
			for (int i = 0; i < SListStr.Count; i++)
			{
                ListViewItem lItem = listView1.Items.Add(SListStr.Keys[i].ToString());
            lItem.SubItems.Add(SListStr.Values[i]);
			}         
		}
private void button2_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the key to find the  index of", "", "", -1, -1);
	int tempindex = SListStr.IndexOfKey(Convert.ToInt32(tempKey));
	if (tempindex < 0)
	{
		MessageBox.Show("The key does not exist in the sortedlist.");
	}
	else
	{
		MessageBox.Show("The key in the sortedlist has an index : " + tempindex + ".");
	}
}
private void button3_Click(object sender, EventArgs e)
{
	string tempValue = Microsoft.VisualBasic.Interaction.InputBox("Enter the value to find  the index of", "", "", -1, -1);
	int tempindex = SListStr.IndexOfValue(tempValue.ToString());
	if (tempindex < 0)
	{
		MessageBox.Show("The value does not exist in the sortedlist.");
	}
	else
	{
		MessageBox.Show("The value in the sortedlist has an index : " + tempindex + ".");
	}
}

	}
}
