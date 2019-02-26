using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebFormCases2.xmlDemo
{
    public partial class XmlElementMethodDes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XElement ele = XElement.Load(Server.MapPath("/xmlDemo/employees.xml"));
            //IEnumerable<XElement> elements = ele.Descendants("City");
            IEnumerable<XElement> elements = ele.Descendants();
           
            foreach (var item in elements)
            {
               
                Response.Write(HttpUtility.HtmlEncode(item));
                Response.Write("<br/>");
            }
          
          
        }
    }
}