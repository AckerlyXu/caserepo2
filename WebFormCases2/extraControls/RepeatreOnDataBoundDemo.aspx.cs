using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.extraControls
{
    public partial class RepeatreOnDataBoundDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("name"));
            table.Columns.Add(new DataColumn("image"));
            table.Rows.Add("tom", "/images/pagination_icons.png");
            table.Rows.Add("jerry", "/images/panel_tools.png");
            table.Rows.Add("pity", "/images/validatebox_warning.png");
            Repeater1.DataSource = table;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item )
            {
                DataRowView dr = (DataRowView)e.Item.DataItem;
                //   string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Data"]);
                string imageUrl = dr["image"].ToString();
                (e.Item.FindControl("Image1") as Image).ImageUrl = imageUrl;
            }

        }
    }
}