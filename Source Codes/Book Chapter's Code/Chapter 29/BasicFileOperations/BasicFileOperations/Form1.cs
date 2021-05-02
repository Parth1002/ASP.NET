using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BasicFileOperations
{
    public partial class Form1 : Form
    {
        string substringDirectory;
        public Form1()
        {
            InitializeComponent();
            GetDriveList();
        }

        public void GetDriveList()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            comboBox1.Items.Clear();
            foreach (DriveInfo d in allDrives)
            {
                comboBox1.Items.Add(d.Name);
            }
        }
        public void CreateTree(string directoryValue, TreeNode parentNode)
        {
            string[] DirArray = Directory.GetDirectories(directoryValue);
            try
            {
                if (DirArray.Length != 0)
                {
                    foreach (string directory in DirArray)
                    {
                        substringDirectory = directory.Substring(
                        directory.LastIndexOf('\\') + 1,
                        directory.Length - directory.LastIndexOf('\\') - 1);
                        TreeNode myNode = new TreeNode(substringDirectory);
                        parentNode.Nodes.Add(myNode);
                        CreateTree(directory, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }
        }
        private void PaintListView(string root)
        {
            try
            {
                ListViewItem Litem;
                ListViewItem.ListViewSubItem LSubItem;
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                this.listView1.Items.Clear();
                this.listView1.BeginUpdate();
                foreach (System.IO.FileInfo fi in files)
                {
                    Litem = new ListViewItem();
                    Litem.Text = fi.Name;
                    Litem.ImageIndex = 1;
                    Litem.Tag = fi.FullName;
                    LSubItem = new ListViewItem.ListViewSubItem();
                    LSubItem.Text = fi.CreationTime.ToString();
                    Litem.SubItems.Add(LSubItem);
                    LSubItem = new ListViewItem.ListViewSubItem();
                    LSubItem.Text = fi.LastAccessTime.ToString();
                    Litem.SubItems.Add(LSubItem);
                    LSubItem = new ListViewItem.ListViewSubItem();
                    long filesize = fi.Length / 1024 + 1;
                    LSubItem.Text = filesize.ToString() + " KB";
                    Litem.SubItems.Add(LSubItem);
                    this.listView1.Items.Add(Litem);
                }
                this.listView1.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
            this.listView1.View = View.Details;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.FullPath.ToString();
            PaintListView(path);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            listView1.Items.Clear();
            String path = comboBox1.SelectedItem.ToString();
            treeView1.Nodes.Add(path);
            CreateTree(path, treeView1.Nodes[0]);
        }

    }
}
