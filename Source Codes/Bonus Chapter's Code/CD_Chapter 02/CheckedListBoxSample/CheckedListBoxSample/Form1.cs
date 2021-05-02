using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckedListBoxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("Mango", true);
            checkedListBox1.Items.Add("Grapes", true);
            checkedListBox1.Items.Add("Orange", false);
            checkedListBox1.Items.Add("Apple", false);
            checkedListBox1.Items.Add("Banana", true);
            checkedListBox1.Items.Add("Guava", false);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(4, false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int intLoopIndex = 0;
            string strText = null;
            strText = "Checked Items: ";

            for (intLoopIndex = 0; intLoopIndex <= (checkedListBox1.Items.Count - 1);
             intLoopIndex++)
            {
                if (checkedListBox1.GetItemChecked(intLoopIndex) == true)
                {
                    strText += checkedListBox1.Items[intLoopIndex].ToString() + " ";
                }
            }
            textBox1.Text = strText;

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.NewValue)
            {
                case CheckState.Checked:
                    textBox1.Text = "Item " + (e.Index + 1) + " is selected";
                    break;
                case CheckState.Unchecked:
                    textBox1.Text = "Item " + (e.Index + 1) + " is not selected";
                    break;
            }


        }
    }
}
