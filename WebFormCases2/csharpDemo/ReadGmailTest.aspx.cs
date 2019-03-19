//using Limilabs.Client.IMAP;
//using Limilabs.Mail;
//using Limilabs.Mail.MIME;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class ReadGmailTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using (Imap imap = new Imap())
            //{
            //    imap.ConnectSSL("imap.gmail.com",993);
            //    imap.UseBestLogin("ackerlyx@gmail.com", "sishen1994");
            //    imap.SelectInbox();
            //    // get all email uids
            //    List<long> uids = imap.Search(Flag.All);

            //    foreach (var uid in uids)
            //    {
            //        var eml = imap.GetMessageByUID(uid);
            //        IMail email = new MailBuilder().CreateFromEml(eml);
            //        Response.Write(email.Subject);
            //        Response.Write("<br/>");
            //        Response.Write(email.Text);
            //        Response.Write("<br/>");
            //        Response.Write("<br/>");
            //        Response.Write("<br/>");
            //        foreach (MimeData mime in email.Attachments)
                        
            //    {
                        
            //        mime.Save(Server.MapPath("/csharpDemo/") + mime.SafeFileName);
                        
            //    }

            //    }
            //}


          
        }
    }
}