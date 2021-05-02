using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ArrayList_Sample
{
    public partial class Form1 : Form
    {
        private ArrayList ArrLst;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadArrList()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ArrLst.Count; i++)
            {
                listBox1.Items.Add(ArrLst[i]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ArrLst = new ArrayList(10);
            ArrLst.Add("White");
            ArrLst.Add("Black");
            ArrLst.Add("Blue");
            ArrLst.Add("Yellow");
            ArrLst.Add("Green");
            ArrLst.Add("Red");
            ArrLst.Add("Orange");
            ArrLst.Add("Purple");
            ArrLst.Add("Magenta");
            ArrLst.Add("Brown");
            LoadArrList();
            button2.Enabled = true;
            button3.Enabled = true;
        }
private void button2_Click(object sender, EventArgs e)
{
	if (ArrLst.Count > 0)
	{
		ArrLst.Sort();
		LoadArrList();
	}
}
private void button3_Click(object sender, EventArgs e)
{
	string tempKey = Microsoft.VisualBasic.Interaction.InputBox("Enter a color to search  for ", "", "", -1, -1);
		int ArrIndex = ArrLst.BinarySearch(tempKey);
		if (ArrIndex < 0)
		{
			MessageBox.Show("The color does not exist in the list");
		}
		else
		{
		MessageBox.Show("The color " + tempKey + " exists at index : " + ArrIndex);
		}
}   

    }
}
