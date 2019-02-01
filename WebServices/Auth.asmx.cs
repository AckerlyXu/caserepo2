using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for Auth
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Auth : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public bool Login(string username, string password)
        {
           if(username == "admin" &&  password == "admin")
            {
                FormsAuthentication.SetAuthCookie("admin", false);
                return true;
            }
            return false;
        }
        [WebMethod(EnableSession = true)]
        public string GetMsg()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated == true)
            {
                return "Loginin";
            }
            else
            {
                return "not logged in";
            }
        }
        [WebMethod(EnableSession = true)]
        public void LogOut()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
            }
        }

    }
}
