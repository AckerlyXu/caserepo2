using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebFormCases2.Services
{
    /// <summary>
    /// Summary description for AdoSpressTest
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AdoSpressTest : System.Web.Services.WebService
    {

        //[WebMethod]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities"), WebMethod]
        public string helloWorld()
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                using (SqlCommand com = new SqlCommand("insert into employee (name, salary, department_id) values()", con))
                {

                   
                    com.ExecuteNonQuery();
                   
                }
            }
            return "a";
        }
    }
}
