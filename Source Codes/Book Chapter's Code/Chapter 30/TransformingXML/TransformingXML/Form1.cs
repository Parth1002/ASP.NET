using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;


namespace TransformingXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XslCompiledTransform ct = new XslCompiledTransform();
	ct.Load("authors.xslt");
	ct.Transform("authors.xml", "authors.html");
	webBrowser1.Url = new Uri(AppDomain.CurrentDomain.BaseDirectory	+ "authors.html");

        }
    }
}
