using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericHashSetSample
{
    public partial class Form1 : Form
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
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
            for (int i = 0; i < 10; i++)
            {
                set1.Add(i);
            }
            for (int i = 5; i < 15; i++)
            {
                set2.Add(i);
            }
            LoadHashSets();
            button2.Enabled = true;
            button3.Enabled = true;
        }
        private void LoadHashSets()
        {
            listBox1.Items.Clear();
            int[] objArr1 = set1.ToArray();
            for (int i = 0; i < set1.Count; i++)
            {
                listBox1.Items.Add(objArr1[i].ToString());
            }
            listBox2.Items.Clear();
            int[] objArr2 = set2.ToArray();
            for (int i = 0; i < set2.Count; i++)
            {
                listBox2.Items.Add(objArr2[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2);
            foreach (int i in union)
            {
                listBox3.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            HashSet<int> intersect = new HashSet<int>(set1);
            intersect.IntersectWith(set2);
            foreach (int i in intersect)
            {
                listBox3.Items.Add(i.ToString());
            }
        }
    }
}
