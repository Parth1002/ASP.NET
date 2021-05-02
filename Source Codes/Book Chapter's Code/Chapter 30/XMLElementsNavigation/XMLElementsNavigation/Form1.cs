using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XMLElementsNavigation
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
	        XPathDocument pd = new XPathDocument("authors.xml");
	        XPathNavigator pn = ((IXPathNavigable)pd).CreateNavigator();
	        XPathNodeIterator ni = pn.Select("/authorslist/authors[@au_id='409-56-7008']");
	        while(ni.MoveNext())
	        {
		        XPathNodeIterator newni = ni.Current.SelectDescendants(XPathNodeType.Element, false);
		        while(newni.MoveNext())
		        {
			        listBox1.Items.Add(newni.Current.Name + ": "+ newni.Current.Value);
		        }
	        } 

        }
    }
}
