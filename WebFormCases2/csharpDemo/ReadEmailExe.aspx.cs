using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MimeKit;   //使用mail kit
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemp
{
    public partial class ReadEmailExe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                using (var client = new ImapClient())
                {
                    // For demo-purposes, accept all SSL certificates
                    client.ServerCertificateValidationCallback = (s, c, h, en) => true;

                    client.Connect("imap.gmail.com", 993, true);

                    client.Authenticate("ackerlyx@gmail.com", "sishen1994");

                    // The Inbox folder is always available on all IMAP servers...
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly|FolderAccess.None);
                 
                   Response.Write("Total messages: "+ inbox.Count+"<br/>");
                Response.Write("Recent messages:"+ inbox.Recent+"<br/>");
               //var newFolder= client.GetFolder("Social");
               // newFolder.Append(inbox.GetMessage(1));
            //    client.Inbox.AddFlags(new int[] { 0}, MessageFlags.Deleted,true);
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                         
                    foreach (var attachment in message.Attachments)
                    {
                        var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                      
                       
                        using (var stream = File.Create(Server.MapPath("/csharpDemo/") + fileName))
                        {
                            if (attachment is MessagePart)
                            {
                                var rfc822 = (MessagePart)attachment;

                                rfc822.Message.WriteTo(stream);
                           
                            }
                            else
                            {
                                var part = (MimePart)attachment;

                                part.Content.DecodeTo(stream);
                            }
                          
                         


                        }
                      //  File.WriteAllBytes(Server.MapPath("/csharpDemo/") + fileName, bys);
                    }

                    Response.Write( "subject:"+message.Subject+"<br/>");
                    Response.Write("address:" + message.From + "<br/>");
                   
                  
                    Response.Write(message.TextBody);

                    Response.Write("<br/><br/>");
                }

                    client.Disconnect(true);
                }
            
        }
    }
}