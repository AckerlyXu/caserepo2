using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models.Identity;

namespace WebFormCases2.csharpDemo
{
    public partial class SendMailUsingIdentityMessageService : System.Web.UI.Page
    {

        IdentityMessage message;
        protected  void Page_Load(object sender, EventArgs e)
        {


            message = new IdentityMessage() { Destination = "ackerlyx@gmail.com", Subject = "hello this is a test mail level two", Body = "please activate your email thank you" };
            RegisterAsyncTask(new PageAsyncTask(SendEmail));

         
        }
        private async Task SendEmail()
        {
            EmailService emailService = new EmailService();
            await emailService.SendAsync(this.message);
        }
    }
}