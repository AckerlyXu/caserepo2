using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace WebFormCases2.xmlDemo
{
    public partial class ShowXmlInHtml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

              
            WebRequest request = WebRequest.Create("http://www.whoisxmlapi.com/whoisserver/WhoisService");
           
       
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
   
    
            Stream dataStream = response.GetResponseStream();
    
            StreamReader reader = new StreamReader(dataStream);
        
            string responseFromServer = reader.ReadToEnd();

            //  Response.Clear();  // remove other data
            //Response.ContentType = "text/xml";// set content type to text/xml to show xml data
            // Response.Write(responseFromServer); // write the xml
            //  Response.End(); // end the response
          XElement element =   XElement.Load(new StringReader(responseFromServer));
          Response.Write(  element.Element("msg").Value);
            element.Elements("msg").ToList();
            
          
            reader.Close();
            dataStream.Close();
            response.Close();


        }
    }
}