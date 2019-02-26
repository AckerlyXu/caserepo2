using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class RegexDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Match match = Regex.Match("CLAIM NEWS Valid Period.........:               123456", @"CLAIM NEWS Valid Period.+:\s+(\d{6})");
        }
    }
}