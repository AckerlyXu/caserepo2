
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.extraControls;

namespace WebFormCases2.fileDemo
{
    public partial class ShowImagesStoredInDatabase : System.Web.UI.Page
    {
        protected void Page_Init(object sender,EventArgs e)
        {
            bool p = IsPostBack;
            if (!IsPostBack)
            {
             
                ViewState["key"] = "value";
            }
            else
            {
                string value = ViewState["key"].ToString();
            }
         
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
         }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // get the data of the row if you bind data with datatable
                // if you use List<YourModel> as DataSource , you should use as YourModel
                DataRowView view = e.Row.DataItem as DataRowView;
                // get the base64 string of the byte data
                string base64 = Convert.ToBase64String(view[3] as byte[]);
                Image image = e.Row.FindControl("Image1") as Image;
                // set the image's src to base64 string
                image.ImageUrl = "data:image/png;base64," + base64;
            }
        
         }
    }
}