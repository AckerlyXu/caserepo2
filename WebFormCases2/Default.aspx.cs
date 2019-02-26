using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.ServiceReference1;

namespace WebFormCases2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  MyServiceSoapClient client = (MyServiceSoapClient) Activator.CreateInstance(typeof(MyServiceSoapClient)); // use reflection to create client instance

            //MethodInfo info=  typeof(MyServiceSoapClient).GetMethod("HelloWorld");  // get method info of method HelloWorld
            // string result =(string) info.Invoke(client, new object[] { "my test parameter" });   // invoke the method
            //  Response.Write(result);  // output the result

            //var proc1 = new ProcessStartInfo();

            //proc1.UseShellExecute = true;

            //proc1.WorkingDirectory = @"C:\Windows\System32";

            //proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Verb = "runas";
            //proc1.Arguments = " /c ipconfig";
            //proc1.WindowStyle = ProcessWindowStyle.Normal;
            //Process.Start(proc1);




            File.WriteAllText(Server.MapPath("/myrun.bat"),"ipconfig");
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                Arguments = "/c " + Server.MapPath("/myrun.bat")
            };
            Process proc = new Process() { StartInfo = psi };

            proc.Start();
            proc.WaitForExit();
            proc.Close();

        }
    }
}