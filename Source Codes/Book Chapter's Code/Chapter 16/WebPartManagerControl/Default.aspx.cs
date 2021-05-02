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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label2.Visible = true;
        Button2.Visible = false;
        WebPartManager wpm = new WebPartManager();
        string str;
        str = wpm.DisplayMode.Name;
        Label2.Text = str;
        Label1.Visible = true;

    }
}