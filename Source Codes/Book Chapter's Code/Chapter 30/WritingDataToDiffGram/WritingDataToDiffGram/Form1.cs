using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;


namespace WritingDataToDiffGram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
	SqlConnection con = new SqlConnection(str1);
    string str2 = "Select EmployeeID,FirstName,Title,HireDate from Employees";
	SqlDataAdapter da = new SqlDataAdapter(str2, con);
	DataSet ds = new DataSet("employeeslist");
	da.Fill(ds, "Employees");
	DataRow dr = ds.Tables[0].NewRow();
	dr["EmployeeID"] = 7;
	dr["FirstName"] = "King";
	dr["Title"] = "Sales Representative";
	ds.Tables[0].Rows.Add(dr);
	ds.WriteXmlSchema("employees.xdr");
	ds.WriteXml("employeesdiff.xml", XmlWriteMode.DiffGram);
	ds.AcceptChanges();            
	webBrowser1.Url = new Uri(AppDomain.CurrentDomain.BaseDirectory	+ "employeesdiff.xml");

        }
    }
}
