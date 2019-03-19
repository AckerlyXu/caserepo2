using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.officesample
{
    public partial class ExcelisDestoriedProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "application/vnd.ms-excel";

            Response.AddHeader("Content-Disposition", "inline; filename=output.xls");
            Response.WriteFile(Server.MapPath("/officesample/My.xls"));
            Response.End();
        }
    }
}