using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.jsonDemo
{
    public partial class ParseJsonString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            JToken jObject =   JToken.Parse("{report: {Id: \"aaakkj98898983\"}}");
        
            var str = jObject.ToString();
            Response.Write(str);
        }
    }
}