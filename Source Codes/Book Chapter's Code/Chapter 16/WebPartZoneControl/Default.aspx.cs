using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        WebPartManager wpm = new WebPartManager();
        WebPartZone wpz = new WebPartZone();
        String str;
        wpz.MenuLabelText = TextBox1.Text;
        str = wpz.MenuLabelText;
        Label3.Text = "Header text:" + str;

    }
}