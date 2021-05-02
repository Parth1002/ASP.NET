using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiTable
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
            DataSet ds = new DataSet();

            SqlDataAdapter dap = new SqlDataAdapter("select * from [OrderDetails]",
 			connection);
            dap.Fill(ds, "[OrderDetails]");
            dataGridView1.DataSource = ds.Tables["[OrderDetails]"];

            SqlDataAdapter dap1 = new SqlDataAdapter("select * from Orders", connection);
            dap1.Fill(ds, "Orders");
            dataGridView2.DataSource = ds.Tables["Orders"];
        }
    }
}
