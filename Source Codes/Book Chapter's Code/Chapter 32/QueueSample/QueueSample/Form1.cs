using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace QueueSample
{
	public partial class Form1 : Form
	{
		public Queue Q;
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Q = new Queue(10);
			Q.Enqueue("White");
			Q.Enqueue("Black");
			Q.Enqueue("Blue");
			Q.Enqueue("Yellow");
			Q.Enqueue("Green");
			Q.Enqueue("Red");
			Q.Enqueue("Orange");
			Q.Enqueue("Purple");
			Q.Enqueue("Magenta");
			Q.Enqueue("Brown");
			LoadQ();     
			button2.Enabled = true;
			button3.Enabled = true;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			button2.Enabled = false;
			button3.Enabled = false;
		}
		private void LoadQ()
		{
			listBox1.Items.Clear();
			object[] objArr = Q.ToArray();
			for (int i = 0; i < Q.Count; i++) {
                listBox1.Items.Add(objArr[i]);
			}
		}
private void button2_Click(object sender, EventArgs e)
{
	Q.Enqueue(Microsoft.VisualBasic.Interaction.InputBox("Enter the value for the item to  be enqueued.", "", "", -1, -1));
	LoadQ();
}   
private void button3_Click(object sender, EventArgs e)
{
	MessageBox.Show(Q.Dequeue().ToString(), "Item dequeued.");
	LoadQ();
}                                       
	}
}
