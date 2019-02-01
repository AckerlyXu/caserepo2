using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.extraControls
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = Button1.Text;
            Button1.Text = "abc";
        }
    }
}