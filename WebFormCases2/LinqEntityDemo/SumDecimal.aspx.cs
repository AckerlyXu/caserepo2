using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class SumDecimal : System.Web.UI.Page
    {
        DbContext1 context1 = new DbContext1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(context1.Firsts.Sum(f => f.amount.HasValue ? f.amount.Value :0));
          
        }
    }
}