using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.sqldbexe
{
    public partial class SqlInsertIfNotExists : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

           
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand com = new SqlCommand("if not exists ( select count(*) from first where id = 5 ) begin insert into first(info, amount) values('visual', 45.6) end", con))
                    {

                        con.Open();
                      Response.Write( com.ExecuteNonQuery());
                    }
                }
          

            
        }

    }
}