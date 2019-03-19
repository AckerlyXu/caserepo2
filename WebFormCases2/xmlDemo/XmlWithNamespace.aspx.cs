using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebFormCases2.xmlDemo
{
    public partial class XmlWithNamespace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XElement ele = XElement.Load(Server.MapPath("/xmlDemo/dataset.xml"));
            
            XNamespace xmlns = "http://www.w3.org/2001/XMLSchema";

            var query = ele.Descendants(xmlns + "element");
        
           
        }
    }
}