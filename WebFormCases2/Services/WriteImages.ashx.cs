using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebFormCases2.Services
{
    /// <summary>
    /// Summary description for WriteImages
    /// </summary>
    public class WriteImages : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.QueryString["Id"] != null)
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString))
                {
                    // get the id of the category to get the category's image data
                    SqlCommand cmd = new SqlCommand("SELECT image,categoryName FROM [Categories]  WHERE CategoryId = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(context.Request.QueryString["Id"]));
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {

                        context.Response.Buffer = true;
                        context.Response.Charset = "";
                        context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                        context.Response.ContentType = "img/jpeg";
                              // write back the byte data of image then the image will show 
                        context.Response.BinaryWrite((byte[])sdr["image"]);
                        con.Close();
                        context.Response.Flush();
                        context.Response.End();
                    }

                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}