using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Marks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string rNo = PreviousPage.RollNo.Text;
        Label1.Text = "Roll Number : " + rNo;
        ShowMarks(rNo);
    }
    private void ShowMarks(string rollno)
    {
        if (rollno == "S00056")
        {
            Label2.Text = "Science : " + "88";
            Label3.Text = "Maths   : " + "79";
        }
        else
        {
            Label2.Visible = false;
            Label3.Visible = false;
            Label1.Text = "Roll Number does not exist. Please enter valid  roll number.";
        }
    }
}
