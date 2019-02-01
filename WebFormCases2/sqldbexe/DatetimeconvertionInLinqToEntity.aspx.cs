using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models;

namespace WebFormCases2.sqldbexe
{
    public partial class DatetimeconvertionInLinqToEntity : System.Web.UI.Page
    {
        DbContext1 dbContext1 = new DbContext1();
        protected void Page_Load(object sender, EventArgs e)
        {
            // dbContext1.Entity1.AsEnumerable().Where(en => (en.mydate.Value==null?"": en.mydate.Value.ToString("dd/MM/yyyy")).Contains("2018")).ToList();
            var strs = dbContext1.Entity1.Where(en => (en.mydate.Value == null ? "" : SqlFunctions.DatePart("dd", en.mydate) + "/" + SqlFunctions.DatePart("MM", en.mydate) +
             "/" + SqlFunctions.DatePart("yyyy", en.mydate)).Contains("2018"));
            var abc = strs.Select(en => new
            {
                time = en.mydate.Value == null ? "" : SqlFunctions.DatePart("dd", en.mydate) + "/" + SqlFunctions.DatePart("mm", en.mydate) +
             "/" + SqlFunctions.DatePart("yyyy", en.mydate)
            }).ToList();
       
            GridView1.DataSource = abc;
            GridView1.DataBind();
           
           

        }
    }
}