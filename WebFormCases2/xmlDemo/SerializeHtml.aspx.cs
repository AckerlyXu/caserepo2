using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace WebFormCases2.xmlDemo
{
    public partial class SerializeHtml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/plain;charset=utf-8";
           string result = getXmlString(  @"<p>Genre: Architectural Photography</p><p>View looking across river towards temple.</p><p> Subjects = Indian architecture; Indian architecture (Hindu); Stein Collection; temples</p>",
"ScopeContent");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(result);
            string xml  = HttpUtility.HtmlDecode(xmlDocument.InnerText);
            xml = "<ScopeContent>" + xml + "</ScopeContent>";
            //XmlDocument doc2 = new XmlDocument();
            //doc2.LoadXml(xml);
            File.WriteAllText(Server.MapPath("/xmlDemo/access.xml"), xml);
          
        }
        public class Abc
        {
            public string ScopeContent { get; set; }
           
        }
        public string getXmlString(object o, string level)
        {
            StringWriter l_StringWriter = new StringWriter();
            XmlTextWriter l_TextWriter = new XmlTextWriter(l_StringWriter);
            XmlDocument l_Doc = getXmlDocument(o, level);



            l_Doc.WriteTo(l_TextWriter);

            return l_StringWriter.ToString();

        }

        public virtual XmlDocument getXmlDocument(object o, string Level)
        {
            MemoryStream l_Stream = new MemoryStream();
            XmlDocument l_Doc = new XmlDocument();

            XmlSerializer l_Serializer = new XmlSerializer(o.GetType(), new XmlRootAttribute(Level));
            XmlSerializerNamespaces l_SerializerNamespaces
                                          = new XmlSerializerNamespaces();

            // Remove the default namespaces.
            l_SerializerNamespaces.Add("", "");
            l_Serializer.Serialize(l_Stream, o, l_SerializerNamespaces);
            l_Stream.Position = 0;
            l_Doc.Load(l_Stream);
            l_Stream.Close();
            return l_Doc;
        }
    }
}