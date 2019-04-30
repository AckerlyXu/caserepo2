using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class GroupByGridviewExe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Subject", typeof(string)));
            table.Columns.Add(new DataColumn("Option", typeof(string)));
            table.Columns.Add(new DataColumn("Rating", typeof(string)));
            table.Rows.Add("ASSERTIVENESS", "Expresses Ideas/Feelings", "MS");
            table.Rows.Add("ASSERTIVENESS", "Expresses Own Needs", "MS");
            table.Rows.Add("ASSERTIVENESS", "Not Easily Intimidated By Peers", "AS");

            table.Rows.Add("ASSERTIVENESS", "Ask Questions e.g. Who, What, Why etc.", "MS");
            table.Rows.Add("ASSERTIVENESS", "Pays Attention During Lesson", "MS");
            table.Rows.Add("COLOUR", "Can identify colour Red and Yellow", "MS");
            table.Rows.Add("COLOUR", "Can name primary colours", "AS");
            table.Rows.Add("COOPERATION WITH OTHERS", "	Can Share with others", "ES");
            table.Rows.Add("COOPERATION WITH OTHERS", "Friendliness", "ES");
            table.Rows.Add("COOPERATION WITH OTHERS", "Plays along side others", "ES");
            table.Rows.Add("COOPERATION WITH OTHERS", "	Takes Turns", "ES");

            DataTable targetTable = new DataTable();
            targetTable.Columns.Add(new DataColumn("col1", typeof(string)));
            targetTable.Columns.Add(new DataColumn("col2", typeof(string)));
            string current1 = "";
          
            foreach (DataRow row in table.Rows)
            {
                if (current1 != row["Subject"].ToString())
                {
                    targetTable.Rows.Add(row["Subject"].ToString(), "Rating");
                    current1 = row["Subject"].ToString();
                }
                targetTable.Rows.Add(row["Option"].ToString(), row["Rating"].ToString());
            }
            
           GridView1.DataSource = targetTable;
           GridView1.DataBind();

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                if (DataBinder.Eval(e.Row.DataItem, "col2").ToString() == "Rating")
                {
                    e.Row.Font.Bold = true;
                }
            }
           
        }
    }
}