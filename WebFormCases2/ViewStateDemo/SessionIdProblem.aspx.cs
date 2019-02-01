using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.ViewStateDemo
{
    public partial class SessionIdProblem : System.Web.UI.Page
    {
        private string AntiXsrfTokenKey= "__AntiXsrfToken";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            //if (Session["CurrentUser"] == null)
            //{
            //    Response.Redirect("/");
            //}
             Session["current"]="hello";

            //protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
               Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {

                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString();
               Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue,
                    Expires = DateTime.Now.AddMinutes(10.0)
                };
               
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AbandonSession()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            if (Request.Cookies["ASP.NET_SessionId"] != null)
            {
                Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
            }
            if (Request.Cookies["__AntiXsrfToken"] != null)
            {
                Response.Cookies["__AntiXsrfToken"].Value = string.Empty;
                Response.Cookies["__AntiXsrfToken"].Expires = DateTime.Now.AddMonths(-20);
            }
        }

        private string CreateSessionId(HttpContext httpContext)
        {
            var manager = new SessionIDManager();

            string newSessionId = manager.CreateSessionID(httpContext);

            return newSessionId;
        }

        public void SetSessionId(HttpContext httpContext, string newSessionId)
        {
           
                var manager = new SessionIDManager();

                manager.SaveSessionID(httpContext, newSessionId, out bool redirected, out bool cookieAdded);
            

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //var Token = Guid.Empty;
            //try
            //{
                
            //        string email = "abc";
            //    string pw = "123";
            //        AbandonSession();//Delete any existing sessions
            //        var newSessionId = CreateSessionId(HttpContext.Current); //Create a new SessionId
            //        SetSessionId(HttpContext.Current, newSessionId);
            //        Token = Guid.NewGuid();
              
            //}
            //catch (Exception)
            //{
            //    Token = Guid.Empty;
            //    lblMsg.Style.Add("display", "block");
            //}
            //if (Token != Guid.Empty)
            //{
            //    Response.Redirect($"HiddenPage.aspx?token={Token.ToString()}", false);
            //}
            //else
            //{
            //    lblMsg.Style.Add("display", "block");
            //}

        }
        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            
                if (!IsPostBack)
                {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                    ViewState["AntiXsrfUserNameKey"] = Session.SessionID.ToString();
                string a = Session.SessionID.ToString();
                Response.Write(a);
                }
                else
                {
                string b = Session.SessionID.ToString();
                Response.Write(b);
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                       || (string)ViewState["AntiXsrfUserNameKey"] != Session.SessionID)
                    {
                    Response.Write("failed");
                    }
                }
            
            
        }
    }
}