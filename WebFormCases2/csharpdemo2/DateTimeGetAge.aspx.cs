using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpdemo2
{
    public partial class DateTimeGetAge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime time;
            int age = 0;
            if (DateTime.TryParseExact("15-Apr-1985", "dd-MMM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out time)) {
                while ((time= time.AddYears(1)) < DateTime.Now)
                {
                   
                    age++;
                }
            }
            Response.Write(age);
        }
    }
}