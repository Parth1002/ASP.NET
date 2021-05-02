using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

using GCheckout.Checkout;
using GCheckout.Util;

public partial class ItemsDetails : System.Web.UI.Page
{    
    SqlConnection conn = new SqlConnection("Data Source=UMAR-PC;Initial Catalog=Sports;Persist Security Info=True;User ID=sa;Password=1234");
    DataSet ds = new DataSet();
    SqlDataAdapter adp;
    public string itemsId, var;
    public static string generatedId;

    protected void Page_Load(object sender, EventArgs e)
    {
        itemsId = Request.QueryString["ItemsID"];
        LoginView lv = (LoginView)Master.FindControl("HeadLoginView");
        if (!lv.Page.User.Identity.IsAuthenticated)
        {
            Response.Redirect("~/Account/Login.aspx?ReturnUrl=~/ItemsDetails.aspx?ItemsID= " + itemsId);
        }
        else
        {
            adp = new SqlDataAdapter("Select * from Items Where ItemsID = '" + itemsId + "'", conn);
            adp.Fill(ds, "Items");

            imgItem.ImageUrl = "~/Images/Items/" + ds.Tables["Items"].Rows[0]["ImageUrl"].ToString();
            lblItemName.Text = ds.Tables["Items"].Rows[0]["Name"].ToString();
            lblDescription.Text = ds.Tables["Items"].Rows[0]["Description"].ToString();
            lblPrice.Text = ds.Tables["Items"].Rows[0]["Price"].ToString();
            lblStatus.Text = ds.Tables["Items"].Rows[0]["Status"].ToString();
        }
    }

    public void validatequantity(object source, ServerValidateEventArgs range)
    {
        if (Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(ds.Tables["Items"].Rows[0]["Quantity"].ToString()))
        {
            range.IsValid = false;
            var = "false";
        }
        else
        {
             range.IsValid =true;
             var = "true";
        }
    }
   
    protected void GCheckoutButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (var == "false")
        {
            return;
        }
        else
        {
            LoginView lv = (LoginView)Master.FindControl("HeadLoginView");
            generatedId = null;
            string orderid = generateOrderId();

            SqlCommand insertOrder = new SqlCommand("Insert into OrderDetails Values(" + orderid + "," + itemsId + "," + Convert.ToInt32(txtQuantity.Text.Trim()) + ",'" + lv.Page.User.Identity.Name + "', '" + DateTime.Now.ToShortDateString() + "')", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            insertOrder.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
                conn.Close();

            CheckoutShoppingCartRequest Req = GCheckoutButton1.CreateRequest();
            Req.AddItem("(Order ID-"+ orderid +")",lblItemName.Text.Trim() , Convert.ToDecimal(lblPrice.Text.Trim()), Convert.ToInt32(txtQuantity.Text.Trim()));
            GCheckoutResponse Resp = Req.Send();
            Response.Redirect(Resp.RedirectUrl, true);
        }
    }

    private string generateOrderId()
    {
        string num = System.Guid.NewGuid().ToString();
        int charCount = 0;
        foreach (char c in num)
        {
            if (char.IsDigit(c))
            {
                generatedId += c.ToString();
                charCount += 1;
            }
            if (charCount == 6)
            {
                break;
            }
        }
        return generatedId;
    }
}