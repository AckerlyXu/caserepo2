using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.Services
{
    public partial class CallWebapi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:64238/api/values");
         
            // Get the response.
          HttpWebResponse response = (HttpWebResponse)request.GetResponse();

           
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            JArray jArray = JArray.Parse(responseFromServer);
            Response.Write(jArray[0]["Title"]);


        }
    }
}