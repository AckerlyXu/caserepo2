using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class SendEmailSomeTimesFail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //send the message
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //to authenticate we set the username and password properites on the SmtpClient
                smtp.Credentials = new NetworkCredential("ackerlyx@gmail.com", "sishen1994");//no need to mention here?
                for (int i = 0; i < 30; i++)
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("ackerlyx@gmail.com");
                        mail.To.Add("ackerlyx@gmail.com");
                        //set the content
                        mail.Subject = "my subject";
                        mail.Body = "my body";
                       
                        smtp.Send(mail);

                    }
                    //set the addresses
                }



            }
        }
    }
}