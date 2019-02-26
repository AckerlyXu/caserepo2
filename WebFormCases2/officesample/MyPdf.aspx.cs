using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.officesample
{
    public partial class MyPdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            string filePath = Server.MapPath("/officesample/abc.pdf");
            Response.ContentType = "application/pdf";
            Response.WriteFile(filePath);
            Response.End();
        }
    }
}