using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.JqueryPlugins
{
    public partial class PnotifyJsExe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value =".                                                 --------------------------------------------------                Helllo world               --------------------------------------------------.                                                 xxx                                     EUR 15.60 .                                                 yyy";
            string[] values = value.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            TextBox1.Text = String.Join("",values.Take(5))+  "\r\n" + string.Join(" ", values.Skip(5).Take(4))+"\r\n"+values[9];
         
          
            DataTable table = new DataTable();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         //   Response.Write("aqui passei");

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", @"

$(function(){

showMessage('title','msg')
})




", true);

        }
    }
}