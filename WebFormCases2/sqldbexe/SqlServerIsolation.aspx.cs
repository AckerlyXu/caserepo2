using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.sqldbexe
{
    public partial class SqlServerIsolation : System.Web.UI.Page
    {
        private static string constr = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

           
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;

                    // Start a local transaction.
                    transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable,"SampleTransaction");

                    // Must assign both transaction object and connection
                    // to Command object for a pending local transaction
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                 
                        command.CommandText =
                            "select max(id) from dbo.customer";
                        command.ExecuteNonQuery();

                    // Attempt to commit the transaction.

                    Thread.Sleep(100000);
                    transaction.Commit();
                      
                    }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                    catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                    {
                      
                        try
                        {
                            transaction.Rollback();
                        }
#pragma warning disable CS0168 // The variable 'ex2' is declared but never used
                        catch (Exception ex2)
#pragma warning restore CS0168 // The variable 'ex2' is declared but never used
                        {
                         
                        }
                    }
                }
            
        }
    }
}