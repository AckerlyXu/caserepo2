using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models.Identity;

namespace WebFormCases2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            FormsAuthentication.SetAuthCookie("user", true);
            //AppUser user = UserManager.FindByEmail("ackerly@gmail.com");
            //string id = user.Id;
            //Session["user_id"] = id;
        }
        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        private AppUserManager UserManager
        {
            get
            {
                IOwinContext content = HttpContext.Current.GetOwinContext();
               
                return content.GetUserManager<AppUserManager>();

            }
        }
        public class UserModel
        {
            public string Email { get; set; }
            public string PasswordHash { get; set; }
            public string Username { get; set; }
            public string Id { get; set; }

            public string Role { get; set; }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         Task<AppUser> result =   UserManager.FindAsync(TextBox1.Text, TextBox2.Text);
                      
            AppUser user = result.Result;

            if (user != null)
            {
                ClaimsIdentity ident = UserManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                AuthManager.SignOut();
                
                AuthManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
               IPrincipal principle=   HttpContext.Current.User;
             IIdentity  identity =  principle.Identity;
              string name =  identity.Name;
             
            }

        }
    }
}