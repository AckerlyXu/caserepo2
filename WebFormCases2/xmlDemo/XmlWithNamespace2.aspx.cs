using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebFormCases2.xmlDemo
{
    public partial class XmlWithNamespace2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          XDocument element =  XDocument.Load(Server.MapPath("/xmlDemo/cache.xml"));
            var posts = from item in element.Descendants("item").Take(5)
                        select new
                        {
                            Title = item.Element("title").Value,
                            Publish = DateTime.Parse(item.Element("pubDate").Value),
                            Url = item.Element("link").Value,
                            Description = item.Element("description").Value.LastIndexOf("<")==-1? item.Element("description").Value: item.Element("description").Value.Substring(0, item.Element("description").Value.LastIndexOf("<"))
                        };
           var postitems = posts.ToList();
        }
    }
}