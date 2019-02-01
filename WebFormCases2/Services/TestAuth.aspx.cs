using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.Services
{
    public partial class TestAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Auth.AuthSoapClient authSoapClient = new Auth.AuthSoapClient();
            using (new OperationContextScope(authSoapClient.InnerChannel))
            {
                authSoapClient.Login("admin", "admin");

                // Extract the cookie embedded in the received web service response
                // and stores it locally
                HttpResponseMessageProperty response = (HttpResponseMessageProperty)
                OperationContext.Current.IncomingMessageProperties[
                    HttpResponseMessageProperty.Name];
                string header  = response.Headers["Set-Cookie"];
                Session["header"] = header;
            }
          
           
        }

        protected void getLoginMsg_Click(object sender, EventArgs e)
        {
            Auth.AuthSoapClient authSoapClient = new Auth.AuthSoapClient();
            using (new OperationContextScope(authSoapClient.InnerChannel))
            {
           

                // Extract the cookie embedded in the received web service response
                // and stores it locally
                HttpRequestMessageProperty request = new HttpRequestMessageProperty();
                request.Headers["Cookie"] = (Session["header"] as string).Split(';')[0];
                OperationContext.Current.OutgoingMessageProperties[
                    HttpRequestMessageProperty.Name] = request;
                string msg = authSoapClient.GetMsg();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}