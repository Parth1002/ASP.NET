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


namespace ConvertingADO.NETDataIntoXMLData
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            string str1 = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection con = new SqlConnection(str1);
            string str2 = "Select EmployeeID,FirstName,Title,HireDate from Employees";
            SqlDataAdapter da = new SqlDataAdapter(str2, con);
            ds = new DataSet("employeeslist");
            da.Fill(ds, "Employees");
            dataGridView1.DataSource = ds.Tables["Employees"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.WriteXml("employees.xml");
            webBrowser1.Url = new Uri(AppDomain.CurrentDomain.BaseDirectory + "employees.xml"); 
        }
    }
}
