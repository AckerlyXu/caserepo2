using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class GridViewSqlAdapter : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
         
            //数据绑定一般在!IsPostBack中做
            if (!IsPostBack)
            {

                // sqldataAdapter接收sql语句与connection string
                //它会内部创建sqlcommand
                using (SqlDataAdapter adapter = new SqlDataAdapter("select * from MasterInfo_Log  ", constr))
                {
                    // adapter 有多个command都是sqlCommond类型
                    //这里由于是查询，使用SelectCommand
                    //可以通过Parameters属性向sql语句中插入参数，AddWithValue是一种简单写法， 比较 adapter.SelectCommand.Parameters.Add(new SqlParameter(namf,value))，这样就不需要创建sqlparameter了

                    // adapter.SelectCommand.Parameters.AddWithValue(parameterName,value)

                    //初始化Datatable
                    DataTable table = new DataTable();
                    //将adapter中的数据整个填充到table中，这样table中就有所有查出来的数据了，不用像sqldataReader一条一条读取
                    adapter.Fill(table);
                 
                    GridView1.DataSource = table; //datatable能够作为Gridview的数据源
                    GridView1.DataBind(); // 绑定数据 这样就能在页面中显示数据
                }



                                                             
                
                    //using (SqlDataAdapter adapter = new SqlDataAdapter("select info,amount from first where id>@myid", constr))
                    //{
                    //    adapter.SelectCommand.Parameters.AddWithValue("@myid", 3); // the value of the parameter @myid is 3
                    //    DataTable table = new DataTable();
                    //    adapter.Fill(table);
                    //    DropDownList1.DataSource = table;
                    //    DropDownList1.DataValueField = "amount";     //valueField指的是隐藏字段,通过 DropDownList1.SelectedValue获得的就是选中项的隐藏字段的值

                    //DropDownList1.DataTextField = "info";  //text field指的是显示的字段
                    //    DropDownList1.DataBind();
                    //}
                

            }
            //if (IsPostBack)
            //{
            //    foreach (var item in Request.Form.Keys)
            //    {
            //        Response.Write(item.ToString()+":"+Request.Form[item.ToString()]);
            //        Response.Write("<br/>");
            //    }
             
            //}
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
      
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
              DropDownList list =  e.Row.FindControl("DropDownList1") as DropDownList;
                list.Items.Add(new ListItem("A"));
                list.Items.Add(new ListItem("B"));
                list.Items.Add(new ListItem("C"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow item in GridView1.Rows)
            {
                if (item.RowType == DataControlRowType.DataRow)
                {
                        DropDownList list = item.FindControl("DropDownList1") as DropDownList;
                    
                    foreach (ListItem option in list.Items)
                    {
                        Response.Write(option.Value);
                       
                    }
                    Response.Write("<br/>");
                }

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataKeyArray dataKeyArray = GridView1.DataKeys;
            string[]  abc =GridView1.DataKeyNames;
          
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
      
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           
        }
    }
}