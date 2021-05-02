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
        CatalogZone cz = new CatalogZone();
        String str;
        cz.EmptyZoneText = "No controls found!!!";
        Label4.Text = cz.EmptyZoneText;
        cz.SelectedCatalogPartID = "Selected zone..";
        Label6.Text = cz.SelectedCatalogPartID;
        str = WebPartManager.CatalogDisplayMode.Name;
        Label8.Text = str;
        Label3.Visible = true;
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        Label7.Visible = true;
        Label8.Visible = true;

    }
}