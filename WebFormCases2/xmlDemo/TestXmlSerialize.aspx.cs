using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebFormCases2.xmlDemo
{
    public partial class TestXmlSerialize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
            XobCreation xobCreation = new XobCreation();
           string xml = xobCreation.Create("accessCondition");
            File.WriteAllText(Server.MapPath("/xmlDemo/access.xml"), xml);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml><ArchiveDescription><AccessCondition AccessConditionId=\"1\">Unrestricted</AccessCondition></ArchiveDescription>");
        }
    }
}