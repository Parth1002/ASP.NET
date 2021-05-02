using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BitArraySample
{
    public partial class Form1 : Form
    {
        public BitArray BitArr1, BitArr2;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BitArr1 = new BitArray(10);
            BitArr1.Set(0, false);
            BitArr1.Set(1, false);
            BitArr1.Set(2, true);
            BitArr1.Set(3, true);
            BitArr1.Set(4, true);
            BitArr1.Set(5, true);
            BitArr1.Set(6, false);
            BitArr1.Set(7, false);
            BitArr1.Set(8, true);
            BitArr1.Set(9, false);
            LoadBtArr();
            button2.Enabled = true;
            button3.Enabled = true;
        }
        private void LoadBtArr()
        {
            listView1.Clear();
            listView1.BackColor = Color.Black;
            listView1.ForeColor = Color.White;
            for (int i = 0; i < BitArr1.Count; i++)
            {
                listView1.Items.Add(BitArr1[i].ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BitArr2 = new BitArray(10);
            BitArr2.SetAll(true);
            BitArr1.Xor(BitArr2);
            LoadBtArr();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            BitArr1.Not();
            LoadBtArr();
        }
    }
}
