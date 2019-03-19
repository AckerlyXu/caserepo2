using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebFormCases2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<employee><id>34</id><name>Sam</name><Age>45</Age></employee>"); // load the xml
            
            string json = JsonConvert.SerializeXmlNode(doc); // use SerializeXmlNode to convert the xml to json string
            json = Regex.Replace(json, "\"(\\d+)\"", "$1");  // replace "34","45" with 35 ,45 using regex, or Jobject will parse it as string
            string result = JObject.Parse(json)[doc.FirstChild.Name].ToString(); // get the employee property of JObject
            Response.Write(result); ;
        }

        public class MyModel
        {
            public DateTime DateTime { get; set; }
        }
    }
}