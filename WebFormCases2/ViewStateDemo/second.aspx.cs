using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static WebFormCases2.ViewStateDemo.SessionTest;

namespace WebFormCases2.ViewStateDemo
{
    public partial class second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["data"] == null)
                {
                    Session["data"] = new Dictionary<int, MyModel> {
                        { 1,new MyModel { haveVisited=false,url="/ViewStateDemo/SessionTest"} },
                        { 2,new MyModel { haveVisited=false,url="/ViewStateDemo/second"} }
                    };
                }


                Dictionary<int, MyModel> data = Session["data"] as Dictionary<int, MyModel>;
                int currentPage = 1;
                MyModel obj = null;
                for (int i = 1; i <= 5; i++)
                {
                    obj= data[i];
                    if (obj.haveVisited == false)
                    {
                     currentPage = i;
                        break;
                    }


                }
                int thisPage = 0;
                foreach (var item in data.Keys)
                {
                    if (data[item].url == Request.Path)
                    {
                        thisPage = item;
                    }
                }
                if (currentPage != thisPage)
                {
                    Response.Redirect(obj.url);
                }
                else
                {
                    data[thisPage].haveVisited = true;
                }
            }
        }
    }
}