
using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class ReadMailUsingOpenPop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pop3Client client = new Pop3Client();
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate("ackerlyx@gmail.com", "sishen1994");
            Response.Write(client.GetMessageCount());


            for (int i = client.GetMessageCount(); i >= 1; i--)
            {
                Message message = client.GetMessage(i);

                Response.Write(i+":");
                Response.Write("subject:" + message.Headers.Subject);
                Response.Write("dateSet" + ":"+ message.Headers.DateSent);
                Response.Write("<br/>");
                Response.Write(string.Format("<a href = 'mailto:{1}'>{0}</a>", message.Headers.From.DisplayName, message.Headers.From.Address));
                   
             
                MessagePart body = message.FindFirstHtmlVersion();
                if (body != null)
                {

                    Response.Write("<br/>");
                    Response.Write(body.GetBodyAsText());
                 
                }
                else
                {
                    body = message.FindFirstPlainTextVersion();
                    if (body != null)
                    {
                        Response.Write("<br/>");
                        Response.Write(body.GetBodyAsText());
                      
                    }
                }
                //List<MessagePart> attachments = message.FindAllAttachments();

                //foreach (MessagePart attachment in attachments)
                //{
                //    email.Attachments.Add(new Attachment
                //    {
                //        FileName = attachment.FileName,
                //        ContentType = attachment.ContentType.MediaType,
                //        Content = attachment.Body
                //    });
                //}
                //Emails.Add(email);
                //counter++;
                //if (counter > 2)
                //{
                //    break;
                //}
            }
          
        }
    }
}