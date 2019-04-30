using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class SelectDistinctValue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("SYMBOL_NO", typeof(string)));
            table.Columns.Add(new DataColumn("value", typeof(string)));
            table.Rows.Add("12345", "value1");
            table.Rows.Add("75395", "value2");
            table.Rows.Add("12345", "value3");
            table.Rows.Add("75395", "value4");
            table.Rows.Add("1fafe", "value5");
            var dup_result = from c in table.AsEnumerable()
                             group c by new
                             {
                                 RowId = c["SYMBOL_NO"].ToString()
                             } into g
                             where g.Count() > 1
                             select g.Key.RowId;
            var list = dup_result.ToList();

        }
    }
}