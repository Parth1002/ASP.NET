using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{ 
    SqlConnection conn = new SqlConnection("Data Source=UMAR-PC;Initial Catalog=Sports;Persist Security Info=True;User ID=sa;Password=1234");
    DataSet ds = new DataSet();
    SqlDataAdapter adp;
    public string title;
  
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["PostBack"] = "True";
        
        adp = new SqlDataAdapter("SELECT * FROM Articles", conn);
        ds.Clear();
        adp.Fill(ds, "Articles");
    }
}
