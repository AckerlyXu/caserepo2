using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MyModel> list = new List<MyModel>
                {
                    new MyModel{DateTime=DateTime.Now}
                };
           
            list.Where(x => x.DateTime.ToString("dd/MM/yyyy").Contains(Request["abc"]));
        }

        public class MyModel
        {
            public DateTime DateTime { get; set; }
        }
    }
}