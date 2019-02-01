using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace WebFormCases2.xmlDemo
{
    public partial class generateXsltConditionally : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.Load(Server.MapPath("/xmlDemo/origin.xml"));
            //XmlNodeList list =  xmlDocument.SelectNodes("//Child[text()='should generate xml']");
            //Response.Write(list.Count);
            //if (list.Count > 0)
            //{
            //    parse(Server.MapPath("/xmlDemo/origin.xml"), Server.MapPath("/xmlDemo/trans.xslt"), Server.MapPath("/xmlDemo/test.xml"));
            //}

           
           
        }

        public void parse(string originXml, string xslt, string result)
        {
            XsltSettings settings = new XsltSettings(true, true);

            XPathDocument xPath = new XPathDocument(originXml);

            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();

            xslCompiledTransform.Load(xslt, settings, new XmlUrlResolver());
            using (XmlTextWriter writer = new XmlTextWriter(result, null))
            {
                xslCompiledTransform.Transform(xPath, null, writer);
            };



        }
    }
}