using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.InsertOneToMany
{
    public partial class DepartAndEmp : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               

                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from department", constr))
                    {

                       
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        DropDownList1.DataTextField = "department_name";
                        DropDownList1.DataValueField = "id";
                        DropDownList1.DataSource = table;
                        DropDownList1.DataBind();
                    }
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand com = new SqlCommand("insert into employee (name, salary, department_id) values(@name, @salary, @department_id)", con))
                {
                 
                    com.Parameters.AddWithValue("name", TextBox1.Text);
                    com.Parameters.AddWithValue("salary", TextBox2.Text);
                    com.Parameters.AddWithValue("department_id", DropDownList1.SelectedValue);
                    con.Open();
                    com.ExecuteNonQuery();
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "hello" + "');", true);

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    DropDownList1.SelectedIndex = 0;
                }
            }
        }
    }
}