using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericStackSample
{
	public partial class Form1 : Form
	{
		Stack<string> SStr = new Stack<string>();
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
			SStr.Push("White");
			SStr.Push("Black");
			SStr.Push("Blue");
			SStr.Push("Yellow");
			SStr.Push("Green");
			SStr.Push("Red");
			SStr.Push("Orange");
			SStr.Push("Purple");
			SStr.Push("Magenta");
			SStr.Push("Brown");
			LoadS();
			button2.Enabled = true;
			button3.Enabled = true;
		}
		private void LoadS()
		{
			listBox1.Items.Clear();
			string[] objArr = SStr.ToArray();
			for (int i = 0; i < SStr.Count; i++)
			{
				listBox1.Items.Add(objArr[i]);
			}
		}
private void button2_Click(object sender, EventArgs e)
{
	string tempStr = Microsoft.VisualBasic.Interaction.InputBox("Enter the value for the  item to be pushed.", "", "", -1, -1);
	SStr.Push(tempStr);
	LoadS();
}
private void button3_Click(object sender, EventArgs e)
{
	MessageBox.Show(SStr.Pop().ToString(), "Item Popped.");
	LoadS(); 
}
	}
}
