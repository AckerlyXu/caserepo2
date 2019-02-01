using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.jsonDemo
{
    public partial class ReadJsonFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText(Server.MapPath("/jsonDemo/json.json"));
           List<RootObject> root = JsonConvert.DeserializeObject<List<RootObject>>(json);
            GridView1.DataSource = root;
            GridView1.DataBind();
        }
    }
    public class RootObject
    {
        public int id { get; set; }
        public string title { get; set; }
    }
}