using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.sqldbexe
{
    public partial class RandowRecordMysql : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int start = new Random().Next(6);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("select * from student limit @start,2", constr))
                {

                    adapter.SelectCommand.Parameters.AddWithValue("start", start);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    GridView1.DataSource = table;
                    GridView1.DataBind();
                }
            }
          
        }
    }
}