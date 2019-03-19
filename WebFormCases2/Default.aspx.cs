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
using WebFormCases2.Models;
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




            //File.WriteAllText(Server.MapPath("/myrun.bat"),"ipconfig");
            //ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
            //{
            //    UseShellExecute = false,
            //    RedirectStandardInput = true,
            //    Arguments = "/c " + Server.MapPath("/myrun.bat")
            //};
            //Process proc = new Process() { StartInfo = psi };

            //proc.Start();
            //proc.WaitForExit();
            //proc.Close();
            // Session["abc"] = "abc";
            Class1 class1 = new Class1();
            // class1.Size = -10;
            // throw new ArgumentOutOfRangeException(nameof(class1.Size ));
           // TimeSpan span = TimeSpan.FromTicks(131969088000000000);
           Response.Write( new DateTime(1970, 01, 01).Ticks);
            Response.Write("<br/>");
            Response.Write(new DateTime(2019, 3, 13).Ticks);
            Response.Write("<br/>");
            Response.Write(new DateTime(636880320000000000).ToString("yyyy-MM-dd  HH:mm"));
            Response.Write("<br/>");
                                                          //15463008000000000
            Response.Write(new DateTime(621355968000000000+ 131969521243673000).ToString("yyyy-MM-dd  HH:mm"));
            Response.Write("<br/>");
            Response.Write(new DateTime(131969521123675000).AddHours(3).ToString("yyyy-MM-dd  HH:mm"));
        }

        public class Class1
        {
            private int _size;
            public int Size
            {
                get => _size;
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(Size));
                    }

                    _size = value;
                }
            }
        }
    }
}