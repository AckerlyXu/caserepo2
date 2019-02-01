using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.dropdownDemo
{
    public partial class binddropdownwithjs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ThreadPool.QueueUserWorkItem(ThreadProc,"hello");
           
            Thread.Sleep(1000);
            System.Diagnostics.Debug.WriteLine("Main thread does some work, then sleeps.----------------------------------------------");



            if (!IsPostBack)
            {
                HttpClient client = new HttpClient();
                string obj = client.GetStringAsync("http://localhost:64238/api/values").Result;
               object dy = JsonConvert.DeserializeObject<object>(obj);
                Region.DataTextField = "Text";
                Region.DataValueField = "Value";
                Region.DataSource = dy;
                Region.DataBind(); 
            }
          
        }
            static void ThreadProc(Object stateInfo)
              {
               Thread.Sleep(10000);
          HttpContext httpContext =   HttpContext.Current;
                System.Diagnostics.Debug.WriteLine("Hello from the thread pool.------------------------------------------------");
               }


protected void Button1_Click(object sender, EventArgs e)
        {

            DropDownList list = Region;
            Response.Write("selectedValue:"+Region.SelectedValue+"&nbsp;&nbsp;"+"selectedText:" +Region.SelectedItem.Text);
        }
    }
}