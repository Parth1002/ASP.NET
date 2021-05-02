using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for MyWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class MyWebService : System.Web.Services.WebService {

    public MyWebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
  public DataSet GetData()
		{
			System.Data.SqlClient.SqlConnection sqlConnection1 = new 
			 System.Data.SqlClient.SqlConnection();
			sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
			string select = "SELECT EmployeeID, FirstName, LastName,  City, Country FROM Employees";
			SqlDataAdapter da = new SqlDataAdapter(select, sqlConnection1);
			DataSet ds = new DataSet();
			da.Fill(ds);
			return (ds);
		}

    
}
