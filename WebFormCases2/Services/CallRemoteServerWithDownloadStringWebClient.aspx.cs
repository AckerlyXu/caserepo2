using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.Services
{
    public partial class CallRemoteServerWithDownloadStringWebClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();


          //  client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            string s = client.DownloadString("https://en.wikipedia.org/wiki/Malaria");
            Response.Write(s);
          
        }  
    }
}