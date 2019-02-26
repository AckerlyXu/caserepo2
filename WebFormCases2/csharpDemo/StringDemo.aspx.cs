using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class StringDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder stb = new StringBuilder("|abc|def|hij|");
            string result = stb.ToString().Trim('|');
         
            Response.Write(result);
            
        }
    }
}