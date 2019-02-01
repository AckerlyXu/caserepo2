using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection;
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


            string abc = Page.ViewStateUserKey;
        }
    }
}