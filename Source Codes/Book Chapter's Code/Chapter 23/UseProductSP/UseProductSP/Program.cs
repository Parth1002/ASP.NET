using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace UseProductSP
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            var con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetProductDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            var param = new SqlParameter("@productId", 3);
            cmd.Parameters.Add(param);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (sdr.Read())
            {
                Console.WriteLine("Product ID: {0} \nItem: {1} \nQuantity:{2} \nPrice:{3}", sdr["ProductID"], sdr["ProductName"], sdr["QuantityPerUnit"], sdr["UnitPrice"]);
            }
            sdr.Close();

        }
    }
}
