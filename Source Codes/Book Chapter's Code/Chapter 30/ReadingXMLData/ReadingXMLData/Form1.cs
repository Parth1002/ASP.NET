using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace ReadingXMLData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlReader xr = XmlReader.Create("authors.xml");
            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Text)
                    listBox1.Items.Add(xr.Value);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlReader xr = XmlReader.Create("authors.xml");
            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element && xr.Name == "au_lname")
                    listBox1.Items.Add(xr.ReadElementString());
                else
                    xr.Read();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlReader xr = XmlReader.Create("authors.xml");
            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element)
                {
                    for (int i = 0; i < xr.AttributeCount; i++)
                        listBox1.Items.Add(xr.GetAttribute(i));
                }
            }

        }
    }
}
