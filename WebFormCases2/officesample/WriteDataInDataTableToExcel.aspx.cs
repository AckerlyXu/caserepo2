using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.officesample
{
    public partial class WriteDataInDataTableToExcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("/officesample/My.xlsx");
            FileInfo file = new FileInfo(filePath);
            using (ExcelPackage excelPackage = new ExcelPackage(file)) // read the data from an excel
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[1];  // get the first sheet of the excel
                worksheet.Cells[10, 3].Value = " input data in 5,3";         // set the value of the cell 10,3  , 10 represents row , 3 represents column
                worksheet.Cells[6, 7].Value = "input data in 6,7";
                worksheet.Cells[2, 3].Style.Numberformat.Format = "0.00";  //set the format of number in 2,3 to 0.00
                excelPackage.Save();
            }
            
        }
    }
}