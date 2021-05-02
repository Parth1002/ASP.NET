using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            int intLoopIndex = 0;
            for (intLoopIndex = 0; intLoopIndex <= 20; intLoopIndex++)
            {
                comboBox1.Items.Add("Item " + intLoopIndex.ToString());
            }
            comboBox1.Text = "Select one...";
            MessageBox.Show("The combo box contains " + comboBox1.Items.Count + " items.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
	{
		int selectedIndex = 0;
		selectedIndex = comboBox1.SelectedIndex;
		object selectedItem = null;
		selectedItem = comboBox1.SelectedItem;
		textBox1.Text = "Selected item text: " + selectedItem.ToString() + " Selected index: " + selectedIndex.ToString();
	}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        public class DataItem
        {
            private float Data;
            private string Name;
            public DataItem(string NameArgument, float Value)
            {
                Name = NameArgument;
                Data = Value;
            }

            public override string ToString()
            {
                return System.Convert.ToString(Name);
            }

            public float GetData()
            {
                return Data;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DataItem[] Objects = new DataItem[21];
            int intLoopIndex = 0;
            for (intLoopIndex = 0; intLoopIndex <= 20; intLoopIndex++)
            {
                Objects[intLoopIndex] = new DataItem("Item " + intLoopIndex,
                System.Convert.ToSingle(intLoopIndex));
                comboBox1.Items.Add(Objects[intLoopIndex]);
            }
            comboBox1.Text = "Select one...";



        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                if (comboBox1.SelectedItem.GetType() == typeof(DataItem))
                {
                    textBox1.Text = "The data for the item you selected is: " +
                    ((DataItem)comboBox1.SelectedItem).GetData();
                }
            }

        }
    }
}
