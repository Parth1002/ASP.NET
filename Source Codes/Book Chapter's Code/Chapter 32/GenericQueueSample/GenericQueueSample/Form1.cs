using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GenericQueueSample
{
	public partial class Form1 : Form
	{
		Queue<string> QStr = new Queue<string>();
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
			QStr.Enqueue("White");
			QStr.Enqueue("Black");
			QStr.Enqueue("Blue");
			QStr.Enqueue("Yellow");
			QStr.Enqueue("Green");
			QStr.Enqueue("Red");
			QStr.Enqueue("Orange");
			QStr.Enqueue("Purple");
			QStr.Enqueue("Magenta");
			QStr.Enqueue("Brown");
			LoadQ();
			button2.Enabled = true;
			button3.Enabled = true;
		}
		private void LoadQ()
		{
			listBox1.Items.Clear();
			string[] objArr = QStr.ToArray();
			for (int i = 0; i < QStr.Count; i++)
			{
                listBox1.Items.Add(objArr[i]);
			}            
		}
private void button2_Click(object sender, EventArgs e)
{
	QStr.Enqueue(Microsoft.VisualBasic.Interaction.InputBox("Enter the value for the item  to be enqueued.", "", "", -1, -1));
	LoadQ();
}
private void button3_Click(object sender, EventArgs e)
{
	MessageBox.Show(QStr.Dequeue().ToString(), "Item dequeued.");
	LoadQ();
}
	}
}
