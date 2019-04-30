using System;
using System.Web;

namespace WebFormCases2
{
    public class PhpModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
          //  context.LogRequest += new EventHandler(OnLogRequest);
            context.BeginRequest += new EventHandler(OnRequest);
        }

        #endregion

        public void OnRequest(Object source, EventArgs e)
        {
            string originalUrl = HttpContext.Current.Request.Url.PathAndQuery;

            // Look for the .php extension
            int index = originalUrl.ToLower().IndexOf(".php");
            if (index >= 0)
            {
                // Make new url by replacing the .php extension with .aspx
                string newUrl = HttpContext.Current.Request.Url.PathAndQuery.Substring(0, index)
         + ".aspx" +
          HttpContext.Current.Request.Url.PathAndQuery.Substring(index + 4);
                HttpContext.Current.RewritePath(newUrl);
              
               
            }
        }
    }
}
