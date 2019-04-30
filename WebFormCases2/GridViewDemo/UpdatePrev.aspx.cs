using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class UpdatePrev : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("AccountID", typeof(int)));
                table.Columns.Add(new DataColumn("AccountName", typeof(string)));
                table.Columns.Add(new DataColumn("SubAccount", typeof(string)));
                table.Rows.Add(1, "", "sub1");
                table.Rows.Add(2, "", "sub2");
                table.Rows.Add(3, "", "sub3");
                gvchild.DataSource = table;
                gvchild.DataBind();


            }
        }

        protected void gvchild_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            // here you could get the previoud gridview row and  save the data 
            GridViewRow row = gvchild.Rows[Convert.ToInt32(HiddenField1.Value)];
           TextBox   account =row.FindControl("txtaccountname") as TextBox;
                TextBox    subaccount = row.FindControl("txtsubaccount") as TextBox;
            Response.Write(account.Text + ":" + subaccount.Text);

        }
    }
}