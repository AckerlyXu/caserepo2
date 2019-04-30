using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpdemo2
{
    public partial class TcpserverDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TcpListener tcplistener = new TcpListener(IPAddress.Any, 4600);
            tcplistener.Start();
            TcpClient client = tcplistener.AcceptTcpClient();
            NetworkStream clientStream = client.GetStream();

            byte[] message = new byte[4096];
            int bytesRead = 0;

          
           // while (true)
           // {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    Response.Write("Error:receive msg error");
                 //   break;
                }

             

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                //System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                string recvstr = encoder.GetString(message, 0, bytesRead);
                Response.Write(String.Format("Recv:[{1}]:msg:@[{0}] @{2}<br/>", recvstr, client.Client.LocalEndPoint, DateTime.Now.ToString()));

                //send msg to client
                string sendstr = "Server OK";
              
                byte[] buffer = encoder.GetBytes(sendstr);
                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
                        Response.Write(String.Format("Sent:[{1}]:msg:@[{0}] @{2}\r\n", sendstr, client.Client.LocalEndPoint, DateTime.Now.ToString()));
           // }

            client.Close();
        }



    }
}