using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models;
using WebFormCases2.ServiceReference1;

namespace WebFormCases2
{
    public partial class _Default : Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
    

                byte[] data = Convert.FromBase64String("aABlAGwAbABvAA==");
            string decodedString = Encoding.UTF8.GetString(data);

            Response.Write("data in textbox1:" + Request.Form["TextBox1"]);
           // Response.Write(decodedString);
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["name"] = "myname";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Write(Session["name"]);
             

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
        }
        
       
    }
}