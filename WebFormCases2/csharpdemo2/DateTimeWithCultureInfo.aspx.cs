using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpdemo2
{
    public partial class DateTimeWithCultureInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pl-pl");


            CultureInfo culture = new CultureInfo("en-IN");
            DateTime dt = Convert.ToDateTime("02-01-2019", culture);
            string result = dt.ToString("dd/MMM/yyyy", culture);
            Response.Write(result);
            Response.Write("<br/>");
            Response.Write(CultureInfo.CurrentCulture);

        }
    }
}