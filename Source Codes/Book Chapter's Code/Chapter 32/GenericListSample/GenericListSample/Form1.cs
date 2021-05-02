using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GenericListSample
{
	public partial class Form1 : Form
	{
		List<string> LstStr = new List<string>();
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			LstStr.Add("White");
			LstStr.Add("Black");
			LstStr.Add("Blue");
			LstStr.Add("Yellow");
			LstStr.Add("Green");
			LstStr.Add("Red");
			LstStr.Add("Orange");
			LstStr.Add("Purple");
			LstStr.Add("Magenta");
			LstStr.Add("Brown");
			LoadList();
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
		}
		private void LoadList()
		{
			listBox1.Items.Clear();
			for (int i = 0; i < LstStr.Count; i++)
			{
                listBox1.Items.Add(LstStr[i]);
			}
		}
private void button2_Click(object sender, EventArgs e)
{
	string tempvalue = Microsoft.VisualBasic.Interaction.InputBox("Enter a color to insert  in the list", "", "", -1, -1);
	string tempindex=Microsoft.VisualBasic.Interaction.InputBox("Enter the index of the  color to insert at", "", "", -1, -1);
	LstStr.Insert(Convert.ToInt32 ( tempindex), tempvalue);
	LoadList();      
}
private void button3_Click(object sender, EventArgs e) {
	if (listBox1.SelectedIndex > -1) {
		LstStr.RemoveAt(listBox1.SelectedIndex);
		LoadList();
	}
	else {
		MessageBox.Show("Select a value to be removed from the ListBox"); 
	}
}
private void button4_Click(object sender, EventArgs e)
{
	LstStr.Reverse();
	LoadList();
}              
	}
}
