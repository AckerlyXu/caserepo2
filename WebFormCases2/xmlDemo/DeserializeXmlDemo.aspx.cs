using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace WebFormCases2.xmlDemo
{
    public partial class DeserializeXmlDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Fonds));
            Fonds fonds = (Fonds)xmlSerializer.Deserialize(XmlReader.Create(Server.MapPath("/xmlDemo/font.xml")));

            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("/xmlDemo/font.xml"));
            string xml =doc.LastChild.FirstChild.InnerXml;
            SerializeData<Fonds>(new Fonds { ScopeContent = new List<string> { "abc", "def" }, Ok = new List<string> { "KK", "just" } },"d://message.xml");
        }

        public static void SerializeData<T>(T instance, string fileName, params Type[] knownTypes)
        {



            DataContractSerializer serializer = new DataContractSerializer(typeof(T), knownTypes, int.MaxValue, false, false, null);
            using (XmlWriter writer = new XmlTextWriter(fileName, Encoding.UTF8))
            {
                serializer.WriteObject(writer, instance);
            }
            Process.Start(fileName);
        }
    }
   

    [XmlRoot(ElementName = "Fonds")]
    public class Fonds
    {
        [XmlArray(ElementName = "ScopeContent")]
        [XmlArrayItem(ElementName = "p")]
        //[XmlArrayItem(ElementName = "item")]
        
        public List<string> ScopeContent { get; set; }

        public List<string> Ok { get; set; }

    }


    
}