using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

public partial class _Default : System.Web.UI.Page
{
    MyWCFServiceReference.ServiceClient reference = new MyWCFServiceReference.ServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsqr_Click(object sender, EventArgs e)
    {
        Label3.Visible = true;
        lbloutput.Visible = true;
        lbloutput.Text = reference.SquareRoot(Convert.ToDouble(txtfirst.Text)).ToString();
    }

    protected void btncube_Click(object sender, EventArgs e)
    {
        Label3.Visible = true;
        lbloutput.Visible = true;
        lbloutput.Text = reference.CubeRoot(Convert.ToDouble(txtfirst.Text)).ToString();
    }
}
