using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplitContainers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == true)
                splitContainer1.Panel1Collapsed = false;
            else
                splitContainer1.Panel1Collapsed = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
                splitContainer1.Panel2Collapsed = false;
            else
                splitContainer1.Panel2Collapsed = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Orientation == Orientation.Horizontal)
                splitContainer1.Orientation = Orientation.Vertical;
            else
                splitContainer1.Orientation = Orientation.Horizontal;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < e.Node.Nodes.Count; i++)
                listBox1.Items.Add(e.Node.Nodes[i].Text);
        }



         

    }
}
