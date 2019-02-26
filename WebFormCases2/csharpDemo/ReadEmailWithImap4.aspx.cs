using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Imap4;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class ReadEmailWithImap4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            const string hostname = "imap.gmail.com";
            const int portnumber = 993;
            var client = new Imap4Client();
           
            
            client.Connect(hostname, portnumber, true);
            client.SendAuthUserPass("ackerlyx@gmail.com", "sishen1994");
          IEnumerable<string> folders =  client.ListFolders();
            client.SelectFolder(folders.First());
        uint inta=   client.UnreadEmails;
         Imap4Message message =   client.GetEmail(20);
            foreach (var item in folders)
            {
            
                Response.Write(item);
            }
        }
    }
}