using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WorkingWithDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getlist();
        }
        public void getlist()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            listBox1.Items.Clear();
            foreach (DriveInfo d in allDrives)
            {
                listBox1.Items.Add(d.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteddrive = listBox1.SelectedItem.ToString();
            DriveInfo GetInfo = new DriveInfo(selecteddrive);
            if (GetInfo.IsReady == true)
            {

                label9.Text = GetInfo.DriveType.ToString();
                label10.Text = GetInfo.DriveFormat.ToString();
                label11.Text = GetInfo.IsReady.ToString();

                long drivespace = GetInfo.TotalSize;
                drivespace = drivespace / 1024;
                drivespace = drivespace / 1024;
                label12.Text = drivespace.ToString() + " MB";
                long Totalfreespace = GetInfo.TotalFreeSpace;
                Totalfreespace = Totalfreespace / 1024;
                Totalfreespace = Totalfreespace / 1024;
                label13.Text = Totalfreespace.ToString() + " MB";
                label15.Text = GetInfo.VolumeLabel.ToString();
                long AvailableFreespace = GetInfo.AvailableFreeSpace;
                AvailableFreespace = AvailableFreespace / 1024;
                AvailableFreespace = AvailableFreespace / 1024;
                label14.Text = AvailableFreespace.ToString() + " MB";
            }

            else
            {
                label9.Text = "";
                label10.Text = "";
                label11.Text = "Drive not ready";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";
                listBox1.Text = "";
                label15.Text = "";

            }
        }


    }
}
