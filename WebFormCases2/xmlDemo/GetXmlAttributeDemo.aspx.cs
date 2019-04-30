using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace WebFormCases2.xmlDemo
{
    public partial class GetXmlAttributeDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml = File.ReadAllText(Server.MapPath("/xmlDemo/request.xml"));

         XElement element =   XElement.Load(new StringReader(xml),LoadOptions.None);

            string value=   element.Descendants("query").First().Attribute("queryString").Value;
        }
    }
}