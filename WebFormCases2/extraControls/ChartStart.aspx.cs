using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.extraControls
{
    public partial class ChartStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = default(DataTable);

            dt = CreateDataTable();

            foreach (DataRow row in dt.Rows)
            {
                //data of the first  series 
                Chart1.Series[0].Points.AddXY(row["Date"], row["Volume1"]);
                //data of the second series
              //  Chart1.Series[1].Points.AddXY(row["Date"], row["Volume2"]);
                //add the second y Axis
                
            }
          //  Chart1.Series[1].YAxisType = System.Web.UI.DataVisualization.Charting.AxisType.Secondary;
           
          //  Chart1.ChartAreas[0].AxisY2.LabelStyle.Format = "{0.00} %";

        }
        private DataTable CreateDataTable()

        {

            //Create a DataTable as the data source of the Chart control

            DataTable dt = new DataTable();



            //Add three columns to the DataTable

            dt.Columns.Add("Date");

            dt.Columns.Add("Volume1");

            dt.Columns.Add("Volume2");

            dt.Rows.Add("Jan", 3731, 50);

            dt.Rows.Add("Feb", 4324, 10);

            dt.Rows.Add("Mar", 4935, 80);

            dt.Rows.Add("Apr", 4466, 13);


            return dt;

        }
    }
}