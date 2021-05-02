using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SearchElements
{
    public partial class Form1 : Form
    {
        private XmlDocument xd = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            xd.Load("authors.xml");
            XmlNodeList nl = xd.GetElementsByTagName("au_lname");
            foreach (XmlNode node in nl)
                listBox1.Items.Add(node.InnerText);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "authorslist/authors[au_lname='" + listBox1.SelectedItem.ToString() + "']";
            XmlNode foundNode = xd.SelectSingleNode(str);
            if (foundNode != null)
                MessageBox.Show(foundNode.OuterXml);

            else
                MessageBox.Show("Node not found");

        }
    }
}
