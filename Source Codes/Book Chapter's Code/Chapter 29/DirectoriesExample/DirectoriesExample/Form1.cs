using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DirectoriesExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetDriveList();
        }

        public void GetDriveList()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            listBox1.Items.Clear();
            foreach (DriveInfo d in allDrives)
            {
                listBox1.Items.Add(d.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = "";
            listBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(listBox1.SelectedItem.ToString());
            DirectoryInfo[] dirs = dir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            listBox2.Items.Clear();
            foreach (DirectoryInfo di in dirs)
            {
                listBox2.Items.Add(di.FullName);
            }
            return;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(listBox2.SelectedItem.ToString());
            DirectoryInfo[] dirs = dir.GetDirectories();
            listBox3.Items.Clear();
            foreach (DirectoryInfo di in dirs)
            {
                listBox3.Items.Add(di.FullName);
            }
            return;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo root = new DirectoryInfo(listBox3.SelectedItem.ToString());
            FileInfo[] files = root.GetFiles();
            label10.Text = root.CreationTime.ToString();
            label11.Text = root.LastAccessTime.ToString();
            listBox4.Items.Clear();
            int filecounter = 0;
            foreach (FileInfo file in files)
            {
                listBox4.Items.Add(file.Name);
                filecounter = filecounter + 1;
            }
            label9.Text = filecounter.ToString();
            label8.Text = listBox3.SelectedItem.ToString();
        }


    }
}
