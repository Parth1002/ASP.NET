using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataViews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetTable().DefaultView;
        }

        public DataTable GetTable()
        {
            string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            DataTable customers = new DataTable("Customers");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand selectAllCustomers = connection.CreateCommand();
                selectAllCustomers.CommandText = "select * from [Customers]";
                connection.Open();
               customers.Load(selectAllCustomers.ExecuteReader(CommandBehavior.CloseConnection));
            }
            return customers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(GetTable());
            dv.Sort = "City ASC";
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(GetTable());
            dv.RowFilter = "Country = 'Mexico'";
            dataGridView1.DataSource = dv;
        }

    }
}
