using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Large Icons");
            comboBox1.Items.Add("Details");
            comboBox1.Items.Add("Small Icons");
            comboBox1.Items.Add("List");
                  }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listView1.View = View.LargeIcon;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listView1.View = View.Details;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listView1.View = View.SmallIcon;
            }
            else 
            {
                listView1.View = View.List;
            }
          

        }
        private void LoadListView()
        {
            listView1.View = View.Details;

            // Add columns
            listView1.Columns.Add("Title",-2,HorizontalAlignment.Left);
            listView1.Columns.Add("Painter",-2,HorizontalAlignment.Left);
            listView1.Columns.Add("Price",-2,HorizontalAlignment.Left);
            
            listView1.LargeImageList = LargeImageList;
            listView1.SmallImageList = SmallImageList;

            // Add items
            ListViewItem item1 = new ListViewItem("Picture 1");
            item1.SubItems.Add("Charu");
            item1.SubItems.Add("1111.53");
          
            item1.ImageIndex = 0;

            ListViewItem item2 = new ListViewItem("Picture 2");
            item2.SubItems.Add("Kamlesh");
            item2.SubItems.Add("5555.99");
          
            item2.ImageIndex = 1;

            ListViewItem item3 = new ListViewItem("Painter 3");
            item3.SubItems.Add("Deepa");
            item3.SubItems.Add("6666.99");
           
            item3.ImageIndex = 2;

            ListViewItem item4 = new ListViewItem("Painter 4");
            item4.SubItems.Add("Vineet");
            item4.SubItems.Add("6666.99");
           
            item4.ImageIndex = 3;

                     // Add the items to the ListView.
            listView1.Items.AddRange(
                                    new ListViewItem[] {item1, 
                                                item2, 
                                                item3, 
                                                item4}
                                    );

        }
    }
}
