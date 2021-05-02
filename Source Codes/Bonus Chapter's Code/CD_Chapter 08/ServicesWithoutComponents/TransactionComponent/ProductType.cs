using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TransactionComponent
{
    public class ProductType
    {
        public int AddProductType(int productID, string productType)
        {
            int productTypeID;
            string connString = @"Data Source=umar-pc;Initial Catalog=Products;Integrated Security=True";
            string commandName = "AddProductTypes";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(commandName, conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter paramProductID = new SqlParameter("@ProductID",SqlDbType.Int);
                paramProductID.Direction = ParameterDirection.Input;
                paramProductID.Value = productID;
                command.Parameters.Add(paramProductID);
                SqlParameter paramProductType = new SqlParameter("@ProductType",SqlDbType.VarChar, 50);
                paramProductType.Direction = ParameterDirection.Input;
                paramProductType.Value = productType;
                command.Parameters.Add(paramProductType);
                SqlParameter paramReturnValue = new SqlParameter("@@identity",SqlDbType.VarChar, 250);
                paramReturnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(paramReturnValue);
                command.ExecuteNonQuery();
                productTypeID = (int)command.Parameters["@@identity"].Value;
            }
            return productTypeID;
        }
    }
}
