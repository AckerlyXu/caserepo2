using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class MoveCursor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < 50; i++)
                {
                    list.Add(i);
                }
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            GridViewRow row = ((sender as TextBox).NamingContainer )as GridViewRow;
            TextBox field = (row.FindControl("TextBox2") as TextBox);
            foreach (GridViewRow item in GridView1.Rows)
            {
               
                if(item.RowIndex != row.RowIndex)
                {
                    item.Enabled = false;
                  //  item.Visible = false;
                }
            }
            field.Focus();
        }
    }
}