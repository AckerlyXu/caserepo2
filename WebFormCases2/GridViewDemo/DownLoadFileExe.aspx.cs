using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class DownLoadFileExe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("fileName"));
                table.Rows.Add("abc.pdf");
                table.Rows.Add("rep.pdf");
                GridView1.DataSource = table;
                GridView1.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //if you want to get the filename , you could use the following two line of code 
            LinkButton button = sender as LinkButton;
            string filename = button.Text;



            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.pdf");

            Response.Clear();
            Response.ContentType = "application/pdf";

            Response.WriteFile(Server.MapPath("/GridViewDemo/abc.pdf"));
            Response.End();
        }
    }
}