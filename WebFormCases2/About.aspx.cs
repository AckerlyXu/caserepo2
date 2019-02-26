
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
        private static string constr = ConfigurationManager.ConnectionStrings["NorthwindConnectionString3"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
          

                SqlConnection con = new SqlConnection(constr);
                using (SqlCommand com = new SqlCommand("select * from customers", con))
                {
                    try
                    {
                       
                        con.Open();



                    using ( SqlDataReader reader =com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Response.Write(reader.GetString(2));
                            }
                        }
                    }
                    }
                    catch (Exception)
                    {
                        con.Close();
                        con.Dispose();

                        throw;
                    }

                }

            

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