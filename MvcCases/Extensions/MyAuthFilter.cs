using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MvcCases.Extensions
{
    public class MyAuthFilter : FilterAttribute,IAuthenticationFilter
    {
        private static int count = 0;
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (count == 0)
            {
                filterContext.HttpContext.Response.Write("HELLO");
                string parameter = string.Format("realm=\"{0}\"", filterContext.HttpContext.Request.Url.DnsSafeHost);

                AuthenticationHeaderValue challenge = new AuthenticationHeaderValue(
                    "Basic", parameter);
                filterContext.HttpContext.Response.Headers["WWW-Authenticate"] = challenge.ToString();
                filterContext.Result = new HttpUnauthorizedResult();
                
                count++;
            }
        
           
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
          
        }
    }
}