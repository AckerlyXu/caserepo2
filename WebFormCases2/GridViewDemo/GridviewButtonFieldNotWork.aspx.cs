using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class GridviewButtonFieldNotWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdDStaff.DataSource = new int[] { 1, 2, 3 };
                grdDStaff.DataBind();
            }
            Response.Write(DateTime.Now.ToString());
        }
    }
}