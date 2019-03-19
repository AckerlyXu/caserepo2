using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace WebFormCases2.Services
{
    /// <summary>
    /// Summary description for MyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MyService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<TrainingDates> HelloWorld(int user_id)
        {

            //  table.Columns.Add(new DataColumn("column1", typeof(string)));
            //table.Rows.Add("a");
            //table.Rows.Add("b");
            //table.Rows.Add("c");
            var TDates = new List<TrainingDates>();
            var js = new JavaScriptSerializer();
            var dates = new TrainingDates
            {
                training_title = "Induction Workshop has been scheduled on 27th – 29th March 2019",
                date = "2/24/2019 12:00:00 AM"
            };

            TDates.Add(dates);
            return TDates;
            //Context.Response.Write(js.Serialize(TDates));

        }
        [WebMethod]
        public User HelloWorld2(User user)
        {

            //  table.Columns.Add(new DataColumn("column1", typeof(string)));
            //table.Rows.Add("a");
            //table.Rows.Add("b");
            //table.Rows.Add("c");
            return user;

        }




    }
    public class TrainingDates
    {
        public string training_title { get; set; }
        public string date { get; set; }
    }
   public  class User
    {
        public int user_id { get; set; }
    }
}
