﻿
using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {
          
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