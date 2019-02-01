using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebFormCases2.Services
{
    public partial class MyWebServiceClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ServicePointManager.Expect100Continue = true;

            ServicePointManager.ServerCertificateValidationCallback = (object abc, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => { return true; };

            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create("http://currencyconverter.kowabunga.net/converter.asmx/GetCurrencies");
  
            webRequest.Method = "get";

            //here add your certificate
          
      

           
      
           // ConverterSoapClient client = new ConverterSoapClient("hello");
           
         //Response.OutputStream.R
        }
    }
}