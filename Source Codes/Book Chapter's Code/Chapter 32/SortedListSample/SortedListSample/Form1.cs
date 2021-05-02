using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SortedListSample
{
    public partial class Form1 : Form
    {
        private SortedList SLst;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLst = new SortedList(10);
            SLst.Add(100, "White");
            SLst.Add(101, "Black");
            SLst.Add(102, "Blue");
            SLst.Add(103, "Yellow");
            SLst.Add(104, "Green");
            SLst.Add(105, "Red");
            SLst.Add(106, "Orange");
            SLst.Add(107, "Purple");
            SLst.Add(108, "Magenta");
            SLst.Add(109, "Brown");
            LoadSrtList();
            button2.Enabled = true;
            button3.Enabled = true;
        }
        private void LoadSrtList()
        {
            for (int i = 0; i < SLst.Count; i++)
            {
                listView1.Items.Add(SLst.GetKey(i).ToString());
                listView1.Items[i].SubItems.Add(SLst[SLst.GetKey(i)].ToString());
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;            

        }
private void button2_Click(object sender, EventArgs e) {
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter the key to find the  index of", "", "", -1, -1);
	int tempindex = SLst.IndexOfKey(Convert.ToInt32(tempKey));
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
	int tempindex = SLst.IndexOfValue(tempValue.ToString());
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
