using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.JqueryPlugins
{
    public partial class PnotifyJsExe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         //   Response.Write("aqui passei");

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", @"

$(function(){

showMessage('title','msg')
})




", true);

        }
    }
}