using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Gallery_Photo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string imgUrl = Request.QueryString["ImageUrl"];
        Img.ImageUrl = "~/Images/Gallery/" +imgUrl;
        
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string filename = Img.ImageUrl; 
        if (filename != "")
        {
            string path = Server.MapPath(filename);
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            if (file.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.ContentType = "application/octet-stream";
                Response.WriteFile(file.FullName);
                Response.End();
            }
            else
            {
                Response.Write("This file does not exist.");
            }
        }
    }
}