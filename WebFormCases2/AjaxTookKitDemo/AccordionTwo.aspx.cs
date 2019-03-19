using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.AjaxTookKitDemo
{
    public partial class AccordionTwo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArrayList list = new ArrayList()
            {
                new {Header="header",content = "Content"}
            };
                Accordion1.DataSource = list;
                Accordion1.DataBind();
                Accordion2.DataSource = list;
                Accordion2.DataBind();
            }
         

        }
    }
}