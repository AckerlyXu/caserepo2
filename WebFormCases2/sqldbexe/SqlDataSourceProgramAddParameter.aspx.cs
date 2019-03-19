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
    public partial class SqlDataSourceProgramAddParameter : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                // using (MySqlDataAdapter adapter = new MySqlDataAdapter("select * from student where name=? ", constr))
                // {

                //adapter.SelectCommand.Parameters.AddWithValue("@a", "我的天哪");
                //     DataTable table = new DataTable();
                //     adapter.Fill(table);
                // GridView1.DataSource = table;
                // GridView1.DataBind();
                // }
                SqlDataSource1.SelectCommand = "SELECT * FROM student where name=?";
                SqlDataSource1.SelectParameters.Add("@b", "xiaoming");
          
                GridView1.DataSourceID = "SqlDataSource1";
           


            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           //string abc = TextBox1.Text;
           // Response.Write(abc);
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "SELECT * FROM student where name=?";
            SqlDataSource1.SelectParameters.Clear();
            SqlDataSource1.SelectParameters.Add("@b", "我的天哪");
            SqlDataSource1.DataBind();
        }
    }
}