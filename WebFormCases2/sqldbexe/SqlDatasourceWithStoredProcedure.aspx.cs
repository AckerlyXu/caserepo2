using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.sqldbexe
{
    public partial class SqlDatasourceWithStoredProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.SelectParameters.Add("address", "address");
            SqlDataSource1.SelectParameters.Add("apprYears", "1");
           
            DataView view = SqlDataSource1.Select(DataSourceSelectArguments.Empty) as DataView;
            
            Response.Write(view.Count);

        }
    }
}