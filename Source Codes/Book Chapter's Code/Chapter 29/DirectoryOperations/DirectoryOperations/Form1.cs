using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DirectoryOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GetDriveList()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            listBox1.Items.Clear();
            foreach (DriveInfo d in allDrives)
            {
                listBox1.Items.Add(d.Name);
                listBox4.Items.Add(d.Name);
                listBox6.Items.Add(d.Name);
            }
        }

        public void GetRootDirList()
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

        public void GetRootDirList__Rename()
        {
            DirectoryInfo dir = new DirectoryInfo(listBox4.SelectedItem.ToString());
            DirectoryInfo[] dirs = dir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            listBox3.Items.Clear();
            foreach (DirectoryInfo di in dirs)
            {
                listBox3.Items.Add(di.FullName);
            }
            return;
        }

        public void GetRootDirList__Delete()
        {
            DirectoryInfo dir = new DirectoryInfo(listBox6.SelectedItem.ToString());
            DirectoryInfo[] dirs = dir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            listBox5.Items.Clear();
            foreach (DirectoryInfo di in dirs)
            {
                listBox5.Items.Add(di.FullName);
            }
            return;
        }

        public void CreateDir()
        {
            string drive = listBox1.SelectedItem.ToString();
            string name = textBox1.Text;
            string dirname = drive + name;
            DirectoryInfo di = new DirectoryInfo(@dirname);
            try
            {
                if (di.Exists)
                {
                    MessageBox.Show("That path exists already.");
                    return;
                }
                di.Create();
                MessageBox.Show("The directory was created successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public void RenameDir()
        {
            string dirname = listBox3.SelectedItem.ToString();
            string tragetdrive = listBox4.SelectedItem.ToString();
            string newname = textBox2.Text;
            string targetdirname = tragetdrive + newname;
            Directory.Move(dirname, targetdirname);
            GetRootDirList__Rename();
        }

        public void DeleteDir()
        {
            string dirname = listBox5.SelectedItem.ToString();
            Directory.Delete(dirname);
            GetRootDirList__Delete();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteDir();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = listBox1.SelectedItem.ToString();
            GetRootDirList();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRootDirList__Rename();
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRootDirList__Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDir();
            GetRootDirList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RenameDir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDriveList();
            label3.Text = "";
        }
    }
}
