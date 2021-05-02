using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace StackSample
{
	public partial class Form1 : Form
	{
		private Stack S;
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			S = new Stack(10);
			S.Push("White");
			S.Push("Black");
			S.Push("Blue");
			S.Push("Yellow");
			S.Push("Green");
			S.Push("Red");
			S.Push("Orange");
			S.Push("Purple");
			S.Push("Magenta");
			S.Push("Brown");
			LoadS();    
			button2.Enabled = true;
			button3.Enabled = true;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			button2.Enabled = false;
			button3.Enabled = false;
		}
		private void LoadS()
		{
			listBox1.Items.Clear();
			object[] objArr = S.ToArray();
			for (int i = 0; i < S.Count; i++)
			{
				listBox1.Items.Add(objArr[i]);
			}
		}
private void button2_Click(object sender, EventArgs e)
{
	S.Push(Microsoft.VisualBasic.Interaction.InputBox("Enter the value for the item to be  pushed.", "", "", -1, -1));
	LoadS();           
}
private void button3_Click(object sender, EventArgs e)
{
	MessageBox.Show(S.Pop().ToString(), "Item Popped.");
	LoadS(); 
}         
	}
}
