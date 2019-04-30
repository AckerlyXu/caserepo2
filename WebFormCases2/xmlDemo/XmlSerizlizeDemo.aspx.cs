using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace WebFormCases2.xmlDemo
{
    public partial class XmlSerizlizeDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SerializeXml<PRECIO_VENTA>( new PRECIO_VENTA { type= "Edm.Decimal",Value=null },Server.MapPath("/xmlDemo/message.xml"));
        }

        public static void SerializeXml<T>(T instance, string fileName)
        {

            using (XmlWriter writer = new XmlTextWriter(fileName, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, instance);
            }
            Process.Start(fileName);
        }

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
        public partial class PRECIO_VENTA
        {

          
            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
            public string type
            {
                get;
                set;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]

            public decimal? Value
            {
                get;
                set;
            }
        }
    }

   
}