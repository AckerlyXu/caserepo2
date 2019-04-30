using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.bootstrapexe
{
    public partial class withAjaxtoolkitCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("id", typeof(int)));
                table.Columns.Add(new DataColumn("DocName", typeof(string)));
                
                table.Rows.Add(1,"doc1");
                table.Rows.Add(2, "doc2");
                table.Rows.Add(3, "doc3");
                HSPolicyDocsDG.DataSource = table;
                HSPolicyDocsDG.DataBind();
            }
        }
    }
}