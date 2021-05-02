using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ShowingNodes
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
            XmlDocument xd = new XmlDocument();
            xd.Load("authors.xml");
            XmlElement newAuthor = xd.CreateElement("authors");
            newAuthor.SetAttribute("au_id", "712-45-1867");
            XmlElement lname = xd.CreateElement("au_lname");
            lname.InnerText = "del Castillo";
            newAuthor.AppendChild(lname);
            XmlElement fname = xd.CreateElement("au_fname");
            fname.InnerText = "Innes";
            newAuthor.AppendChild(fname);
            xd.DocumentElement.AppendChild(newAuthor);
            XmlTextWriter tr = new XmlTextWriter("newAuthors.xml", null);
            tr.Formatting = Formatting.Indented;
            xd.WriteContentTo(tr);
            tr.Close();
            XmlNodeList nl = xd.GetElementsByTagName("au_lname");
            foreach (XmlNode node in nl)
                listBox1.Items.Add(node.InnerText);

        }
    }
}
