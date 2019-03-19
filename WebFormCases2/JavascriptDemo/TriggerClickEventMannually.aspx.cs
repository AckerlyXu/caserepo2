using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.JavascriptDemo
{
    public partial class TriggerClickEventMannually : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button1 clicked");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Button2 clicked");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write("Button3 clicked");
        }
    }
}