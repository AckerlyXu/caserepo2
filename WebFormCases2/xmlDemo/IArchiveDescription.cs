using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WebFormCases2.xmlDemo
{
    public class IAMSAccessConditionCV
    {

        public IAMSAccessConditionCV() { }

        #region Properties

        /// <summary>
        /// Propery to access the access condition id
        /// </summary>
        [XmlAttribute]
        public short AccessConditionId { get; set; }

        /// <summary>
        /// Propery to access the Access Condition
        /// </summary>
        [XmlText]
        public string AccessCondition { get; set; }

        #endregion
    }

    public class ArchiveDescription
    {


        [XmlElement(ElementName = "AccessCondition")]
        public IAMSAccessConditionCV IAMSAccessConditionCV { get; set; } = null;

    }

    public class XobCreation
    {


        public string Create(string accessCondition)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(ArchiveDescription));

            StringBuilder sb = new StringBuilder();


            ArchiveDescription ADItem = new ArchiveDescription();

            ADItem.IAMSAccessConditionCV = new IAMSAccessConditionCV()
            {
                AccessCondition = accessCondition,
                AccessConditionId = 1
            };


            string XMLString = getXmlString(ADItem);

            return XMLString;

        }


        public string getXmlString(ArchiveDescription AD)
        {
            StringWriter l_StringWriter = new StringWriter();
            XmlTextWriter l_TextWriter = new XmlTextWriter(l_StringWriter);
            XmlDocument l_Doc = getXmlDocument(AD);

            l_Doc.WriteTo(l_TextWriter);

            return l_StringWriter.ToString();

        }

        public virtual XmlDocument getXmlDocument(ArchiveDescription AD)
        {
            MemoryStream l_Stream = new MemoryStream();
            XmlDocument l_Doc = new XmlDocument();
            XmlSerializer l_Serializer = new XmlSerializer(typeof(ArchiveDescription));
            XmlSerializerNamespaces l_SerializerNamespaces
                                          = new XmlSerializerNamespaces();

            // Remove the default namespaces.
            l_SerializerNamespaces.Add("", "");

            l_Serializer.Serialize(l_Stream, AD, l_SerializerNamespaces);
            l_Stream.Position = 0;
            l_Doc.Load(l_Stream);
            l_Stream.Close();

            return l_Doc;



        }


    }
}