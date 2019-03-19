using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace WebFormCases2.Models.Identity
{
    public class EmailService : IIdentityMessageService
    {
        public  async Task SendAsync(IdentityMessage message)
        {
            MailMessage mail = new MailMessage();
            //set the addresses
            mail.From = new MailAddress("ackerlyx@gmail.com");
            mail.To.Add(message.Destination);
            //set the content
            mail.Subject = message.Subject;
            mail.Body = message.Body;
            //send the message
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {

                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //to authenticate we set the username and password properites on the SmtpClient
                smtp.Credentials = new NetworkCredential("ackerlyx@gmail.com", "sishen1994");//no need to mention here?
             await smtp.SendMailAsync(mail);
            }
            
            
        }
    }
}