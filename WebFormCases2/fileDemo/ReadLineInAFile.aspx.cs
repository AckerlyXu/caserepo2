using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.fileDemo
{
    public partial class ReadLineInAFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          string[] strs =  File.ReadAllLines(Server.MapPath("/fileDemo/test.txt"));

          Dictionary<string,string> dic =  strs.ToDictionary(key => key.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[0]
            , value => value.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[1]);
            Cache.Insert("values", dic, new System.Web.Caching.CacheDependency(Server.MapPath("/fileDemo/test.txt")));
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = Cache["values"] as Dictionary<string, string>;
        }
    }
}