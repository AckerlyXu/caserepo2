using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebFormCases2.AjaxToolKitDemo
{
    /// <summary>
    /// Summary description for ServiceCS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class ServiceCS : System.Web.Services.WebService
    {

        [WebMethod]
        public CascadingDropDownNameValue[] GetCountries(string knownCategoryValues,
    string category)
        {
            List<CascadingDropDownNameValue> l = new List<CascadingDropDownNameValue>();
            l.Add(new CascadingDropDownNameValue("America", "1"));
            l.Add(new CascadingDropDownNameValue("UK", "2"));
            l.Add(new CascadingDropDownNameValue("France", "3"));
            return l.ToArray();
        }


        [WebMethod]
        public CascadingDropDownNameValue[] GetStates(string knownCategoryValues,
    string category)
        {
             
            int countryId =  Convert.ToInt32(knownCategoryValues.Split(';')[0].Split(':')[1]);
            Dictionary<int, string>  dic= new Dictionary<int, string>
            {
                {1,"America" },
                {2,"UK" },
                {3,"France" }
            };
            List<CascadingDropDownNameValue> l = new List<CascadingDropDownNameValue>();
            for (int i = 1; i <= 3; i++)
            {
                l.Add(new CascadingDropDownNameValue(dic[countryId]+"state"+i,i.ToString()));
              
            }
           
            return l.ToArray();
        }

        [WebMethod]
        public CascadingDropDownNameValue[] GetCity(string knownCategoryValues,
  string category)
        {
            // knownCategoryValues:"CountryId:1;StateId:2;"
            int countryId = Convert.ToInt32(knownCategoryValues.Split(';')[0].Split(':')[1]);
            int stateId = Convert.ToInt32(knownCategoryValues.Split(';')[1].Split(':')[1]);
            Dictionary<int, string> dic = new Dictionary<int, string>
            {
                {1,"America" },
                {2,"UK" },
                {3,"France" }
            };
            List<CascadingDropDownNameValue> l = new List<CascadingDropDownNameValue>();
            for (int i = 1; i <= 3; i++)
            {
                l.Add(new CascadingDropDownNameValue(dic[countryId] + "state"+stateId+"'s city" + i, countryId+""+stateId +""+ i));

            }

            return l.ToArray();
        }
    }
}
