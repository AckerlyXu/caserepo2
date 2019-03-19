using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.jsonDemo
{
    public partial class desirializeToDataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<AbstractTcItem> list = new List<AbstractTcItem>
             {
                 new AbstractTcItem{RecordId="abs1",Xob="<root>123</root>",ModifiedDate=null,ModifiedBy="judy",CataloguedDate=DateTime.Now,ItemTypeId=1},
                  new AbstractTcItem{RecordId="abs2",Xob="<root>456</root>",ModifiedDate=DateTime.Now.AddDays(-10),ModifiedBy="nancy",CataloguedDate=DateTime.Now.AddDays(2),ItemTypeId=1},
                   new AbstractTcItem{RecordId="abs3",Xob="<root>789</root>",ModifiedDate=DateTime.Now.AddDays(-5),ModifiedBy="keke",CataloguedDate=DateTime.Now.AddDays(1),ItemTypeId=1},
                    new AbstractTcItem{RecordId="abs4",Xob="<root>456</root>",ModifiedDate=null,ModifiedBy="mili",CataloguedDate=DateTime.Now.AddDays(12),ItemTypeId=1},
                     new AbstractTcItem{RecordId="abs5",Xob="<root>234</root>",ModifiedDate=null,ModifiedBy="alikesi",CataloguedDate=DateTime.Now,ItemTypeId=1}
             };
           string json= JsonConvert.SerializeObject(new { Table = list });
          DataSet set=  JsonConvert.DeserializeObject<DataSet>(json);

            string consString = ConfigurationManager.ConnectionStrings["EntityDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(consString))
            {
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                {
                    //Set the database table name
                    sqlBulkCopy.DestinationTableName = "dbo.Test";
                    sqlBulkCopy.ColumnMappings.Add("Xob", "ItemXob");

                    sqlBulkCopy.ColumnMappings.Add("RecordId", "RecordId");
                    sqlBulkCopy.ColumnMappings.Add("CataloguedDate", "CaloguedDate");
                    sqlBulkCopy.ColumnMappings.Add("ModifiedBy", "LastModifiedBy");
                    sqlBulkCopy.ColumnMappings.Add("ModifiedDate", "LastModifiedOn");
                    sqlBulkCopy.ColumnMappings.Add("ItemTypeId", "ItemTypeId");
                    con.Open();
                  
                    sqlBulkCopy.WriteToServer(set.Tables[0]);
                    con.Close();
                }
            }
        
        GridView1.DataSource = set;
            GridView1.DataBind();
        }


        public class AbstractTcItem
        {
            public string RecordId { get; set; }
            public string Xob { get; set; }
  
            public DateTime CataloguedDate { get; set; }
            public string ModifiedBy { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public int ItemTypeId { get; set; }
        

        }
    }
}