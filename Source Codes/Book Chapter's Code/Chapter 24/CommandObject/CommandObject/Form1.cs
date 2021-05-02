using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommandObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees", connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Employees");
            comboBox1.DataSource = ds.Tables["Employees"];
            comboBox1.DisplayMember = "EmployeeID";
            comboBox1.ValueMember = "EmployeeID";

        }
    }
}
