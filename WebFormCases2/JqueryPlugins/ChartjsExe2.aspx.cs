using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.JqueryPlugins
{
    public partial class ChartjsExe2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int productNo = 1;
                String chart = "";
                // You can change your chart height by modify height value
                
                    chart = "<canvas id=\"chart-canvaspn1\" width =\"100%\" height=\"30\"></canvas><script>";
                    chart += "new Chart(document.getElementById(\"chart-canvaspn1\").getContext('2d'),{type: 'horizontalBar', data:{ labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],";
                
               
                chart += "datasets: [{ data: ["+ "65, 59, 75, 81, 56, 55, 40";

                // put data from database to chart
              
                //for (int i = 0; i < tb.Rows.Count; i++)
               
                // value += (productNo == 1) ? lstCompFoodItm[0].FirstItem : lstCompFoodItm[0].SecondItem;
                // value = value.Substring(0, value.Length - 1);

                //chart += value;

                chart += "],label: \"Calories\", borderColor: \"#3e95cd\",backgroundColor: \"#ffc266\"}"; // Chart color
                chart += "]}, options: { title: { display: true}, legend: {position: 'bottom'},scales: { xAxes: [{gridLines: {display:false}, ticks:{beginAtZero:true}},barthickness:20], yAxes: [{gridLines:{display:false}}]}}"; // Chart title
            
                chart += "</script>";

              // Response.ContentType = "text/plain";
           // Literal1.Text = chart;
        }
    }
}