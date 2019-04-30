using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//https://forums.asp.net/t/2154056.aspx
namespace WebFormCases2.sqldbexe
{
    public partial class DynamicWhereCaluse : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckBoxList1.SelectedIndex == -1)// if null is selected, return empty table
            {
                DataTable table = new DataTable();
              
                GridView1.DataSource = table;
                GridView1.DataBind();
                return;
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter("",constr ))
                {
                
                string commandText = "select * from customer where name in (";
                bool isFirst = true;
                int count = 1;
            
                foreach (ListItem item in CheckBoxList1.Items)
                {
                    if (item.Selected)
                    {
                        if (isFirst)// if is the first parameter
                        {
                            commandText += "@parameter" + count; // name the parameter, the parameter name will be parameter1, parameter2 ...
                            adapter.SelectCommand.Parameters.AddWithValue("@parameter" + count, item.Value);
                           
                            isFirst = false; // then all the other parameter is not first
                        }
                        else
                        {
                            commandText += ",@parameter" + count;  // other parameter should add ,
                            adapter.SelectCommand.Parameters.AddWithValue("@parameter" + count, item.Value);
                          
                        }

                        count++; // plus one
                    }
                }
                commandText += ")"; // add )

                adapter.SelectCommand.CommandText = commandText;
               

                DataTable table = new DataTable();
                    adapter.Fill(table);
                GridView1.DataSource = table;
                GridView1.DataBind();
                }
            
        }
    }
}