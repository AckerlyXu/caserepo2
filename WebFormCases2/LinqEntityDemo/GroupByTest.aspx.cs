using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class GroupByTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("25.7", "m"));
            list.Add(new KeyValuePair<string, string>("25.6", "n"));
            list.Add(new KeyValuePair<string, string>("25.5", "k"));
            list.Add(new KeyValuePair<string, string>("24.1", "p"));
            list.Add(new KeyValuePair<string, string>("24.4", "q"));
            list.Add(new KeyValuePair<string, string>("24.2", "k"));
            list.Add(new KeyValuePair<string, string>("abc", "u")); 
            list.Add(new KeyValuePair<string, string>("abc", "s"));
            list.Add(new KeyValuePair<string, string>("abc", "o"));
            list.Add(new KeyValuePair<string, string>("23.6", "8"));
            list.Add(new KeyValuePair<string, string>("23.8", "i"));
            list.Add(new KeyValuePair<string, string>("25.9", "v"));
          list =  list.Select(  //select method will map your data , it will input the every key value pair and output the returned value
                kv =>{
                decimal dec;
                if (decimal.TryParse(kv.Key, out dec)) // try parse the key
                {                             
                         // use Math.Round to get the integer of the key 
                        return new KeyValuePair<string, string>(Math.Round(dec).ToString(), kv.Value);

                }
                // if couldn't parse the key, return original keyvalue pair
                    return kv;
            }).ToList();
          var query =  list.GroupBy(kv => kv.Key); // group the dada according the the key
            foreach (IGrouping<string,KeyValuePair<string,string>> group in query) // loop through every group
            {
                Response.Write("<br/>");
                Response.Write(group.Key + " 's count " + group.Count() ); // get the key of group, it will be 26,24,abc, you could get the count of elements in the group throught group.Count()
                Response.Write("<br/>");
                Response.Write("<br/>");
                foreach (KeyValuePair<string,string> item in group)
                {
                    
                    Response.Write(item.Key + ":" + item.Value + "<br/>"); // output every element in the group
                }
            }
            

        }
    }
}