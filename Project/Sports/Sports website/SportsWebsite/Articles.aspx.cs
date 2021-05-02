using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;


public partial class Articles : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=UMAR-PC;Initial Catalog=Sports;Persist Security Info=True;User ID=sa;Password=1234");
    DataSet ds = new DataSet();
    SqlDataAdapter adp, adp1;
    LoginView lv;    
    public static string articleid;
    
    protected void Page_Load(object sender, EventArgs e)
    {       
        articleid = Request.QueryString["ArticleID"];
        lv = (LoginView)Master.FindControl("HeadLoginView");
        if (!lv.Page.User.Identity.IsAuthenticated)
        {
            pnlComments.Visible = false;
            HyperLink1.Visible = true;
        }
        else
        {
            pnlComments.Visible = true;
            HyperLink1.Visible = false;
        }
        
        adp = new SqlDataAdapter("Select * from Articles Where ArticleID = " + articleid, conn);
        ds.Clear();
        adp.Fill(ds, "Articles");
        imgArticle.ImageUrl = ds.Tables["Articles"].Rows[0]["ImageUrl"].ToString();
        lblBody.Text = ds.Tables["Articles"].Rows[0]["Body"].ToString();
        lblTitle.Text = ds.Tables["Articles"].Rows[0]["Title"].ToString();
        lbladdedBy.Text = ds.Tables["Articles"].Rows[0]["AddedBy"].ToString();
        lbladdedDate.Text = ds.Tables["Articles"].Rows[0]["AddedDate"].ToString();

        //Displaying the list of other articles
        adp1 = new SqlDataAdapter("SELECT * FROM Articles WHERE NOT ArticleID = "+ articleid, conn);
        ds.Clear();
        adp1.Fill(ds, "Articles");

        lstArticles.DataSource = ds;
        lstArticles.DataBind();
        
        HyperLink1.NavigateUrl = "~/Account/Login.aspx?ReturnUrl=~/Articles.aspx?ArticleID=" + articleid;

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string name = lv.Page.User.Identity.Name;
        SqlCommand insertcomm = new SqlCommand("Insert into comments (AddedDate, AddedBy, ArticleID, Body) values('"+DateTime.Now +"', '"+ name +"', " + articleid + ",  '"+ txtComments.Text +"')", conn);
        if (conn.State == ConnectionState.Closed)
            conn.Open();
        insertcomm.ExecuteNonQuery();
        if (conn.State == ConnectionState.Open)
            conn.Close();
        dlComments.DataBind();
        txtComments.Text = null;
        Response.Redirect("Articles.aspx?ArticleID=" + articleid);
    }
}

