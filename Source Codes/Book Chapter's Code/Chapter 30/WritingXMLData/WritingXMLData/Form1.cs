using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;





namespace WritingXMLData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings ws = new XmlWriterSettings();
	ws.Indent = true;
	ws.NewLineOnAttributes = true;
	XmlWriter xw = XmlWriter.Create("newAuthors.xml", ws);
	xw.WriteStartDocument();
	xw.WriteStartElement("authorslist");
	xw.WriteStartElement("authors");
	xw.WriteAttributeString("au_id", "409-56-7008");
	xw.WriteElementString("au_lname", "Verma");
	xw.WriteElementString("au_fname", "Charu");
	xw.WriteEndElement();
	xw.WriteStartElement("authors");
	xw.WriteAttributeString("au_id", "648-92-1872");
	xw.WriteElementString("au_lname", "Ahmed");
	xw.WriteElementString("au_fname", "Umar");
	xw.WriteEndElement();
	xw.WriteStartElement("authors");
	xw.WriteAttributeString("au_id", "238-95-7766");
	xw.WriteElementString("au_lname", "Srivastava");
	xw.WriteElementString("au_fname", "Jyoti");
	xw.WriteEndElement();
	xw.WriteStartElement("authors");
	xw.WriteAttributeString("au_id", "722-51-5454");
	xw.WriteElementString("au_lname", "Dixit");
	xw.WriteElementString("au_fname", "Anuj");
	xw.WriteEndElement();
	xw.WriteEndElement();
	xw.WriteEndDocument();
	xw.Flush();
	xw.Close();
	webBrowser1.Url = new Uri(AppDomain.CurrentDomain.BaseDirectory + "newAuthors.xml");

        }
    }
}
