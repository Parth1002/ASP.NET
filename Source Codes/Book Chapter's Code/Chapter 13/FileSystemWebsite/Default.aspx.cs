using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public TextBox RollNo
    {
        get
        {
            return TextBox1;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label3.Visible = true;
        Label3.Text = "Welcome " + TextBox2.Text;
        TextBox1.Enabled = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Response.Redirect("Marks.aspx");
    }
}
