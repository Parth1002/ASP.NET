﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;


namespace ADO.NETtoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection mycon = new SqlConnection();
			SqlDataAdapter myadapter = new SqlDataAdapter();
			SqlCommand cmd = new SqlCommand();
			String dataquery = "SELECT EmployeeID, FirstName, LastName,  City, Country FROM Employees";
			cmd.CommandText = dataquery;
			myadapter.SelectCommand = cmd;
			mycon.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
			cmd.Connection = mycon;
			DataSet ds = new DataSet();
			myadapter.Fill(ds);
			ListViewEmployeeDetails.DataContext = ds.Tables[0].DefaultView;
			mycon.Close();

        }
    }
}
