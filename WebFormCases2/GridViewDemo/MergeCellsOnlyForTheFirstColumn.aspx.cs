using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class MergeCellsOnlyForTheFirstColumn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("Student Name", typeof(string)));
                table.Columns.Add(new DataColumn("Subjects", typeof(string)));
                table.Columns.Add(new DataColumn("Marks", typeof(int)));
                table.Rows.Add("S1", "ECO", 81);
                table.Rows.Add("S1", "GEO", 95);
                table.Rows.Add("S1", "FIN", 98);
                table.Rows.Add("S2", "ECO", 98);
                table.Rows.Add("S2", "FIN", 98);
                StdGrid.DataSource = table;
                StdGrid.DataBind();

            }
        }

      
        protected void StdGrid_DataBound(object sender, EventArgs e)
        {
            for (int i = StdGrid.Rows.Count - 1; i > 0; i--)
            {
                GridViewRow row = StdGrid.Rows[i];
                GridViewRow previousRow = StdGrid.Rows[i - 1];

                if (row.Cells[0].Text == previousRow.Cells[0].Text)
                {
                    if (previousRow.Cells[0].RowSpan == 0)
                    {
                        if (row.Cells[0].RowSpan == 0)
                        {
                            previousRow.Cells[0].RowSpan += 2;
                        }
                        else
                        {
                            previousRow.Cells[0].RowSpan = row.Cells[0].RowSpan + 1;
                        }
                        row.Cells[0].Visible = false;
                    }
                }

            }
        }
    }
}