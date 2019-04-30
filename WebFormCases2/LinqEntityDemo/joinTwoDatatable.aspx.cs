using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class joinTwoDatatable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("F1"));
            table.Columns.Add(new DataColumn("F2"));
            table.Columns.Add(new DataColumn("F3"));
            table.Columns.Add(new DataColumn("F4"));
            table.Rows.Add("Yes", "No", "Yes", "No");
            DataTable table2 = new DataTable();
            table2.Columns.Add(new DataColumn("F1"));
            table2.Columns.Add(new DataColumn("F2"));
            table2.Columns.Add(new DataColumn("F3"));
            table2.Rows.Add("Yes", "Yes", "Yes");
            List<string> table_columns = new List<string>();
            List<string> table2_columns = new List<string>();
            foreach (DataColumn item in table.Columns)// populate table_columns with all the columnnames in table
            {
                table_columns.Add(item.ColumnName);
            }
            foreach (DataColumn item in table2.Columns)// populate table_columns with all the columnnames in table2
            {
                table2_columns.Add(item.ColumnName);
            }
          IEnumerable<string> common_cols=  table_columns.Intersect(table2_columns);// get common column names in table and table2
            DataTable final_table = new DataTable();
            
           
            foreach (string com_col in common_cols)
            {
                 if(table.Rows[0][com_col].ToString()=="Yes" && table2.Rows[0][com_col].ToString()=="Yes")// get all the yes column
                {
                    final_table.Columns.Add(new DataColumn(com_col));
                }
            }
            final_table.Rows.Add(new string[final_table.Columns.Count].Select(c=>"Yes").ToArray());// populate the first row with yes
            GridView1.DataSource = final_table;
            GridView1.DataBind();
       
             
        }
    }
}