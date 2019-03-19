using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class DynamicAddRow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
                
            }
        }
        private void BindGridView()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("id", typeof(int)));
            table.Columns.Add(new DataColumn("name", typeof(string)));
            table.Columns.Add(new DataColumn("age", typeof(int)));
            table.Rows.Add(1, "Nancy", 18);
            table.Rows.Add(2, "Jerry", 21);
            table.Rows.Add(3, "Mike", 13);
            table.Rows.Add(4, "Angle", 17);
            table.Rows.Add(5, "David", 18);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                
                            GridViewRow row = new GridViewRow(0,0, DataControlRowType.DataRow, DataControlRowState.Normal);
                row.Cells.Add(new TableCell() { Text = e.Row.Cells[1].Text ,ColumnSpan=3});
                int rowIndex = e.Row.RowIndex;
                GridView1.Controls[0].Controls.Add(row );
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);

                //To Export all pages
                GridView1.AllowPaging = false;
                this.BindGridView();


                GridView1.RenderControl(hw);

             
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
           }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
             
            Response.Write(e.NewPageIndex);
            BindGridView();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Response.Write(e.CommandName);
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
          
        }
    }
}