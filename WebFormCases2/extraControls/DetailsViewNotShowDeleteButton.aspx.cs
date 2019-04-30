using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.extraControls
{
    public partial class DetailsViewNotShowDeleteButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
        {
            if (e.CommandName == "Cancel")
            {
                //DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
                DetailsView1.DefaultMode = DetailsViewMode.ReadOnly;
                //DetailsView1.DataBind();
            }
          
        }
    }
}