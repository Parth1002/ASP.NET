using System;
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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Trace.Write("----------------Page Load Event");
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        Trace.Write("----------------Page Init Event");
    }
    protected void Page_InitComplete(object sender, EventArgs e)
    {
        Trace.Write("----------------Page InitComplete Event");
    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        Trace.Write("----------------Page LoadComplete Event");
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Trace.Write("----------------Page PreInit Event");
    }
    protected void Page_PreLoad(object sender, EventArgs e)
    {
        Trace.Write("----------------Page PreLoad Event");
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        Trace.Write("----------------Page PreRender Event");
    }
    protected void Page_SaveStateComplete(object sender, EventArgs e)
    {
        Trace.Write("----------------Page SaveStateComplete Event");
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        Trace.Write("----------------Page Unload Event");
    }
}
