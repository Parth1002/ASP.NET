using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericLinkedListSample
{
    public partial class Form1 : Form
    {
        LinkedList<string> LnLstStr = new LinkedList<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LnLstStr.AddLast("White");
            LnLstStr.AddLast("Black");
            LnLstStr.AddLast("Blue");
            LnLstStr.AddLast("Yellow");
            LnLstStr.AddLast("Green");
            LnLstStr.AddLast("Red");
            LnLstStr.AddLast("Orange");
            LnLstStr.AddLast("Purple");
            LnLstStr.AddLast("Magenta");
            LnLstStr.AddLast("Brown");
            LoadLnkdList();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
        private void LoadLnkdList()
        {
            listBox1.Items.Clear();
            foreach (string StrObj in LnLstStr)
            {
                listBox1.Items.Add(StrObj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tempStr = Microsoft.VisualBasic.Interaction.InputBox("Enter a value for the color to be added.", "", "", -1, -1);
            LnLstStr.AddFirst(tempStr);
            LoadLnkdList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tempStr = Microsoft.VisualBasic.Interaction.InputBox("Enter a value for the color to be added.", "", "", -1, -1);
            LnLstStr.AddLast(tempStr);
            LoadLnkdList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                LnLstStr.RemoveFirst();
                LoadLnkdList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string tempStr = Microsoft.VisualBasic.Interaction.InputBox("Enter a value for the color to be added.", "", "", -1, -1);
                LnLstStr.AddAfter(LnLstStr.Find(listBox1.SelectedItem.ToString()), tempStr);
                LoadLnkdList();

            }
            else
            {
                MessageBox.Show("Please select an item from the list first.");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string tempStr = Microsoft.VisualBasic.Interaction.InputBox("Enter a value for the color to be added.", "", "", -1, -1);
                LnLstStr.AddBefore(LnLstStr.Find(listBox1.SelectedItem.ToString()), tempStr);
                LoadLnkdList();
            }
            else
            {
                MessageBox.Show("Please select an item from the list first.");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LnLstStr.RemoveLast();
            LoadLnkdList();
        }
    }
}
    