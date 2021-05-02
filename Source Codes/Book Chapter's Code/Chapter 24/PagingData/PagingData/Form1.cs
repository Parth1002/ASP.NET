using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagingData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pageSize = 5;
            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();
            string orderSQL = "SELECT TOP " + pageSize + " * FROM Orders ORDER BY OrderID";
			SqlDataAdapter adapter = new SqlDataAdapter(orderSQL, connection);
			DataSet DataSet = new DataSet();
			adapter.Fill(DataSet,  "Orders");
			dataGridView1.DataSource = DataSet.Tables["Orders"];
        }
    }
}
