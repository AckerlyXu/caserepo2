using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Imap4;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemo
{
    public partial class ReadGmailUsingSystemNetimap4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new Imap4Client();
            client.Connect("imap.gmail.com", 993, true);
            
           
        }
    }
}