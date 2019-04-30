using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.bootstrapexe
{
    public partial class UpdatePandelAndModal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void ddl_parentreasoncode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_parentreasoncode.SelectedValue != "2")
            {
                ddl_childreasoncode.SelectedIndex = 0;
                ddl_childreasoncode.Enabled = false;

            }
            else
            {
             //   ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "enablePopUpModal()", true);
                ddl_childreasoncode.Enabled = true;
               


                ListItem lichild = new ListItem("Select Reason Code", "-1");
                ddl_childreasoncode.Items.Insert(0, lichild);

            }

        }
    }
}