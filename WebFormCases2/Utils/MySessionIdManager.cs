using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebFormCases2.Utils
{
    public class MySessionIDManager : SessionIDManager, ISessionIDManager
    {
        void ISessionIDManager.SaveSessionID(HttpContext context, string id, out bool redirected, out bool cookieAdded)
        {
            base.SaveSessionID(context, id, out redirected, out cookieAdded);

            if (cookieAdded)
            {
                var name = "ASP.NET_SessionId";
                var cookie = context.Response.Cookies[name];
                cookie.Path = "/IdentityExe";
            }
        }
    }
}