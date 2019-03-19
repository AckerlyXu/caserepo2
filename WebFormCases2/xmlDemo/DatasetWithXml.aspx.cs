using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.xmlDemo
{
    public partial class DatasetWithXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet set = new DataSet();
            set.ReadXml(Server.MapPath("/xmlDemo/dataset.xml"));
            DataTable table = set.Tables["song"];
            
        }
    }
}