using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace ValidatingXMLData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlReaderSettings rs = new XmlReaderSettings();
            rs.Schemas.Add(null, "authors.xsd");
            rs.ValidationType = ValidationType.Schema;
            rs.IgnoreWhitespace = true;
            rs.ValidationEventHandler += new ValidationEventHandler(Validation);
            XmlReader xr = XmlReader.Create("editAuthors.xml", rs);
            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Text)
                    listBox1.Items.Add(xr.Value);
            }
        }
        public void Validation(object sender, ValidationEventArgs e)
        {
            MessageBox.Show(e.Message);
            Close();
        }
    }
}
