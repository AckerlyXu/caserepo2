using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.csharpDemp
{
    public partial class SortStringUsingRownum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Regex regexs = new Regex(@"Ref\s+.+[^Ref]");
           string[] allRows= File.ReadAllText(Server.MapPath("/csharpDemo/TextFile1.txt")).Split(new string[] { "Ref:" },StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"Row\s+no\s+:(\d+)");
           Match match =    regex.Match("Ref : Add MS 89010/17-21, Row no :8,Column name : Reference, Error message:Add MS 89010/17-21 is already in Iams ");
           Group group = match.Groups[1];
        
            string[] orderLine = allRows.OrderBy(line => 
            Convert.ToInt32(

                (regex.Match(line).Groups[1].Value)

                )).ToArray();
            foreach (var item in orderLine)
            {
              //  Response.Write("Ref:"+item+"<br/>");
            }
            EntreeAc.DataSource =new ArrayList() { new { header = "header1", content = "content1" } };
            EntreeAc.DataBind();
            SidesAc.DataSource = new ArrayList() { new { header = "header2", content = "content2" } };
            SidesAc.DataBind();
        }
    }
}