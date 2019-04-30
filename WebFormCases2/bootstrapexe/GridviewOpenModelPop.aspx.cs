using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.bootstrapexe
{
    public partial class GridviewOpenModelPop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("id", typeof(int)) );
                table.Columns.Add(new DataColumn("name", typeof(string)));

                table.Rows.Add(1, "jack");
                table.Rows.Add(2, "mary");
                table.Rows.Add(3, "david");
                GridView1.DataSource = table;
                GridView1.DataBind();
            }
        }

        protected void link_Click(object sender, EventArgs e)
        {
            LinkButton linkbutton = (LinkButton)sender;
         GridViewRow row =   (GridViewRow) linkbutton.NamingContainer;
            TextBox1.Text = row.Cells[0].Text;
            Label3.Text = linkbutton.CommandArgument;
            ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "$('#myModal').modal()", true);
        }
    }
}