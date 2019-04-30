using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using WebFormCases2.Models.Identity;

[assembly: OwinStartup(typeof(WebFormCases2.StartupBack))]

namespace WebFormCases2
{
    public class StartupBack
    {
        public void Configuration(IAppBuilder app)
        {

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.CreatePerOwinContext<AppIdentityDbContext>(AppIdentityDbContext.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            app.CreatePerOwinContext<AppRoleManager>(AppRoleManager.Create);
            app.UseCookieAuthentication(
                new CookieAuthenticationOptions
                {
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath = new PathString("/login.aspx")
                    // CookieName = "mycookiename",
                    // ExpireTimeSpan = TimeSpan.FromSeconds(20)
                }
                );


        }
    }
}
