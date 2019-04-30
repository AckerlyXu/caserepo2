
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models.Identity;

namespace WebFormCases2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            using (Process p = new Process())
            {
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.Arguments = "/c ping www.google.com";
                p.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
                p.Start();

                string line;
                string result="";
                while ((line = p.StandardOutput.ReadLine()) != null)
                {
                    result += line;
                }

                p.WaitForExit();
                Response.Write(result);
                Response.Write("<br/>");
                Response.Write(Request.UserHostAddress);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            IdentityResult  result =UserManager.CreateAsync(new AppUser { UserName = TextBox1.Text }, TextBox2.Text).Result;
          
        }
    }
}