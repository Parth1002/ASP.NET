using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void GetProductDetailsSP(int ProductID)
    {
        SqlConnection con = new SqlConnection("context connection=true");
        con.Open();
        SqlCommand myCommand = new SqlCommand("SELECT ProductID,ProductName,QuantityPerUnit,UnitPrice,UnitsInStock FROM Products WHERE ProductID=@ProductID Order By ProductName", con);
        myCommand.Parameters.Add("@ProductID", SqlDbType.Int);
        myCommand.Parameters["@ProductID"].Value=ProductID;
        SqlDataReader sdr = myCommand.ExecuteReader();
        SqlPipe sp = SqlContext.Pipe;
        sp.Send(sdr);
        con.Close();

    }
};
