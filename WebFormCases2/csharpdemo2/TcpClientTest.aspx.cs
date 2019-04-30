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
    public partial class TcpClientTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IPEndPoint iep = new IPEndPoint(IPAddress.Parse("172.17.107.145"), 3722);
            //TcpClient newcon = new TcpClient(iep);
            //newcon.Connect("172.17.107.145", 4600);

            //Byte[] data = System.Text.Encoding.ASCII.GetBytes("hello");


            //NetworkStream stream = newcon.GetStream();


            //stream.Write(data, 0, data.Length);


            //data = new Byte[256];


            //String responseData = String.Empty;

            //Int32 bytes = stream.Read(data, 0, data.Length);
            //responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            //Response.Write(responseData);
            //stream.Close();
            //newcon.Close();


            int port = 4600;
            string host = "127.0.0.1";//服务器端ip地址

            IPAddress ip = IPAddress.Parse(host);
            IPEndPoint ipe = new IPEndPoint(ip, port);


            IPAddress ipclient = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipc = new IPEndPoint(ip, 3725);

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Bind(ipc);
            clientSocket.Connect(ipe);

            //send message
            string sendStr = "send to server : hello,ni hao";
            byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
            clientSocket.Send(sendBytes);
          
            //receive message
            string recStr = "";
            byte[] recBytes = new byte[4096];
            int bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
            recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            Response.Write(recStr);

            clientSocket.Close();


        }
    }
}