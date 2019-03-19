using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.AjaxToolKitDemo
{
    public partial class CascadeDropdownProblemInFireFox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            cdlCountries.SelectedValue = "2";
            cdlStates.SelectedValue = "4";

        }
    }
}