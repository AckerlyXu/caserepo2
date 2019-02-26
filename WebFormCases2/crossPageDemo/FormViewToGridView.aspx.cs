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

namespace WebFormCases2.crossPageDemo
{
    public partial class FormViewToGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<employee><id>34</id><name>Sam</name><Age>45</Age></employee>");
            string json=  JsonConvert.SerializeXmlNode(doc);
            json = Regex.Replace(json, "\"(\\d+)\"","$1");
            string result = JObject.Parse(json)["employee"].ToString();
            Response.Write(result);

           
        }
    }
}