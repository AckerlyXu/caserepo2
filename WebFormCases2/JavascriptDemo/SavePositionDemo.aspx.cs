using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.JavascriptDemo
{
    public partial class SavePositionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Cottages> list = new List<Cottages>();
                list.Add(new Cottages { MyText = "text1", MyValue = "value1" });
                list.Add(new Cottages { MyText = "text2", MyValue = "value2" });
                list.Add(new Cottages { MyText = "text3", MyValue = "value3" });
     
                BulletedList1.DataTextField = "MyText";
                BulletedList1.DataSource = list;
                BulletedList1.DataBind();
            }
        }

        
        
        
    }
    public class Cottages{
        public string MyValue { get; set; }
        public string MyText { get; set; }
    }
}