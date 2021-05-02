using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace CheckBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true & checkBox2.Checked == false & 
			 checkBox3.Checked == false)
			{
			SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
			con.Open();
			string command = "select  OrderID, ProductID, Quantity from [Order Details] where Quantity > 0 and Quantity < 30";
			SqlCommand cmd = new SqlCommand(command, con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Order Details");
			dataGridView1.DataSource = ds.Tables[0];
			}
			else
			{
		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
			con.Open();
			string command = "select  OrderID, ProductID, Quantity from [Order Details] where Quantity > 30 ";
			SqlCommand cmd = new SqlCommand(command, con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Order Details");
			dataGridView1.DataSource = ds.Tables[0];
			}

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
if (checkBox2.Checked == true & checkBox1.Checked == false & 
			checkBox3.Checked == false)
			{
		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
			con.Open();
			string command = "select OrderID, ProductID, Quantity  from [Order Details] where Quantity > 31 and Quantity < 60";
			SqlCommand cmd = new SqlCommand(command, con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Order Details");
			dataGridView1.DataSource = ds.Tables[0];
			}
			else
			{
		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
			con.Open();
			string command = "select OrderID, ProductID, Quantity  from [Order Details] where Quantity > 60";
			SqlCommand cmd = new SqlCommand(command, con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Order Details");
			dataGridView1.DataSource = ds.Tables[0];
			}

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true & checkBox1.Checked == false & 
			 checkBox2.Checked == false)
			{
			SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
			con.Open();
			string command = "select OrderID, ProductID, Quantity from [Order Details] where Quantity > 61 and Quantity < 90";
			SqlCommand cmd = new SqlCommand(command, con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Order Details");
			dataGridView1.DataSource = ds.Tables[0];
			}
			else
			{
		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
			con.Open();
			string command = "select OrderID, ProductID, Quantity from [Order Details]";
			SqlCommand cmd = new SqlCommand(command, con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Order Details");
			dataGridView1.DataSource = ds.Tables[0];
			}

        }
    }
}
