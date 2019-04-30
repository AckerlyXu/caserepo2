
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace WebFormCases2
{
    public partial class About : Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["NorthwindConnectionString3"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
        
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("NT_GROUP", typeof(string)));
            table.Columns.Add(new DataColumn("Rep_Code", typeof(string)));
            table.Columns.Add(new DataColumn("Rep_Name", typeof(string)));
            table.Rows.Add("group1", "1", "rep1");
            table.Rows.Add("group1", "2", "rep2");
            table.Rows.Add("group1", "3", "rep3");
            table.Rows.Add("group1", "4", "rep1");
            table.Rows.Add("group2", "5", "rep2");
            table.Rows.Add("group2", "6", "rep3");
            table.Rows.Add("group2", "7", "rep1");
            table.Rows.Add("group2", "8", "rep2");
            table.Rows.Add("group3", "9", "rep3");
            table.Rows.Add("group3", "10", "rep1");
            table.Rows.Add("group3", "11", "rep2");
            table.Rows.Add("group3", "12", "rep3");
         table=   table.AsEnumerable().Where(r => r["NT_GROUP"].ToString() != "group1").CopyToDataTable();


           
            Response.Write(DateTimeOffset.Parse("2012-10-08T04:50:12.0000000+08").LocalDateTime+"<br/>");
            Response.Write(DateTimeOffset.Parse("2012-10-08T04:50:12.0000000+08").UtcDateTime + "<br/>");
            Response.Write(DateTimeOffset.Parse("2012-10-08T04:50:12.0000000+08").DateTime + "<br/>");
            Response.Write(DateTimeOffset.Parse("2012-10-08T04:50:12.0000000+08").Offset);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["key"] = "value";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = Session["key"] as string;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    e.Row.FindControl("book").Visible = true;
                    e.Row.FindControl("Label4").Visible = false;
                }
                else
                {
                    e.Row.FindControl("book").Visible = false;
                    e.Row.FindControl("Label4").Visible = true;
                }
               
            }
        }
    }
}