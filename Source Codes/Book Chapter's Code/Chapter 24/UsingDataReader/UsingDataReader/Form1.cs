using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsingDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr = null;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                string ConnectionSrtring = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
                con = new SqlConnection(ConnectionSrtring);
                con.Open();
                string CommandText = "SELECT FirstName, LastName" + "  FROM Employees" + " WHERE (LastName LIKE @Find)";
                cmd = new SqlCommand(CommandText);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@Find", System.Data.SqlDbType.NVarChar, 20, "LastName"));
                cmd.Parameters["@Find"].Value = textBox1.Text;
                rdr = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr["FirstName"].ToString() + " " + rdr["LastName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
