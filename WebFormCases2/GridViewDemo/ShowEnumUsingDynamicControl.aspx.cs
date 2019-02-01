using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models.school;

namespace WebFormCases2.GridViewDemo
{
    public partial class ShowEnumUsingDynamicControl : System.Web.UI.Page
    {

     
        ServiceDbContext serviceDbContext = new ServiceDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = serviceDbContext.ServiceConfigurations.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = serviceDbContext.ServiceConfigurations.ToList();
            GridView1.DataBind();

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(GridView1.EditIndex != -1)
            {
                if (e.Row.RowIndex == GridView1.EditIndex)
                {
                    DropDownList drop = e.Row.FindControl("DropDownList1") as DropDownList;
                    int[] values = Enum.GetValues(typeof(ServiceType)) as int[];
                    var  enums=  values.Select(v => new { key = Enum.GetName(typeof(ServiceType), v), value = v }).ToList();
                    drop.DataTextField = "key";
                    drop.DataValueField = "value";
                
                    ServiceConfiguration con = e.Row.DataItem as ServiceConfiguration;
                    drop.SelectedValue = Convert.ToInt32(con.Type).ToString();
                    drop.DataSource = enums;
                    drop.DataBind();

                }
               
            }
        }
    }
}