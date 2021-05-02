using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuStripAndContextMenuStripSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked " + sender.ToString());

            // code to display item 4
            item4ToolStripMenuItem.Visible = true;
            MessageBox.Show("Displaying Item 4");
        }

        private void item3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disabling Spell Check menu item");
            spellCheckToolStripMenuItem.Enabled = false;
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enabling Spell Check menu item");
            spellCheckToolStripMenuItem.Enabled = true;
        }

        private void item4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiding Item 4");
            item4ToolStripMenuItem.Visible = false;
        }

        private void spellCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spellCheckToolStripMenuItem.Checked = !spellCheckToolStripMenuItem.Checked;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Cut menu item");
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Copy menu item");
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Paste menu item");
            textBox1.Paste();
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripTextBox1.Font = new Font(toolStripComboBox1.SelectedItem.ToString(), (float)(Font.Size), Font.Style);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(toolStripComboBox2.SelectedItem.ToString(), (float)(Font.Size), Font.Style);
        }

       private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem1.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem1.PerformClick();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem1.PerformClick();
        }

   }
}
