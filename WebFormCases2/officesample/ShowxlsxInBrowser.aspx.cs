using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.officesample
{
    public partial class ShowxlsxInBrowser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Server.MapPath("/officesample/CMy.xlsx") + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
          
            OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [mysheet$]", strConn);

       
          
            DataTable dataTable = new DataTable();
            myCommand.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}