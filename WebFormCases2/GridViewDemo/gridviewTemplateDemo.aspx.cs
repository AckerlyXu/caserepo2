using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.GridViewDemo
{
    public partial class gridviewTemplateDemo : System.Web.UI.Page
    {
       
        protected void Page_PreInit(object sender , EventArgs e)
        {
            CreateColumn_GridView5();
            
        }
    protected override void OnInit(EventArgs e)
        {
            
            base.OnInit(e);
          
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
                BindGridView();
            }

        }
        protected void CreateColumn_GridView5()
        {
       
            
                //create the column
                TemplateField customField = new TemplateField();

                customField.HeaderTemplate = new GridViewTemplate(DataControlRowType.Header, "custom");

                customField.ItemTemplate = new GridViewTemplate(DataControlRowType.DataRow, "custom");

                GridView1.Columns.Add(customField);
           


        }


        private void BindGridView()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("id", typeof(int)));
            table.Columns.Add(new DataColumn("name", typeof(string)));
            table.Columns.Add(new DataColumn("age", typeof(int)));
            table.Columns.Add(new DataColumn("Custom", typeof(string)));
            table.Rows.Add(1, "Nancy", 18, "NancyCustom");
            table.Rows.Add(2, "Jerry", 21, "JerryCustom");
            table.Rows.Add(3, "Mike", 13, "MikeCustom");
            table.Rows.Add(4, "Angle", 17,"AngleCustom");
            table.Rows.Add(5, "David", 18, "DavidCustom");
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }


    public class GridViewTemplate : ITemplate
    {
        //2 properties of the class GridViewTemplate
        private DataControlRowType templateType;
        private string columnName;

        //alternative Constructor, takes in 2 parameter
        public GridViewTemplate(DataControlRowType type, string colname)
        {
            templateType = type;
            columnName = colname;
        }

        //need to implement this method because the class implements the interface
        public void InstantiateIn(Control container)
        {
            // Create the content for the different row types.
            switch (templateType)
            {
                case DataControlRowType.Header:
                    // Create the controls to put in the header
                    // section and set their properties.
                    Literal lc = new Literal();
                    lc.Text = "<b>" + columnName + "</b>";

                    // Add the controls to the Controls collection
                    // of the container.
                    container.Controls.Add(lc);
                    break;

                case DataControlRowType.DataRow:
                    // Create the controls to put in a data row
                    // section and set their properties.
                    TextBox firstName = new TextBox();


                    // Add the controls to the Controls collection
                    // of the container.
                    container.Controls.Add(firstName);
                    firstName.DataBinding += new EventHandler(this.FirstName_DataBinding);

                    break;

                // Insert cases to create the content for the other 
                // row types, if desired.

                default:
                    // Insert code to handle unexpected values.
                    break;
            }
        }

        public void FirstName_DataBinding(Object sender, EventArgs e)
        {
            // Get the Label control to bind the value. The Label control
            // is contained in the object that raised the DataBinding 
            // event (the sender parameter).
            TextBox l = (TextBox)sender;

            // Get the GridViewRow object that contains the Label control. 
            GridViewRow row = (GridViewRow)l.NamingContainer;

            // Get the field value from the GridViewRow object and 
            // assign it to the Text property of the Label control.
            //l.Text = DataBinder.Eval(row.DataItem, ).ToString();
            l.CssClass = "form-control-plaintext";
            l.ID = "txtTargetvalue";

            //having issues understanding how this works, I have already binded the data table to the gridview, but this seems to be a replicated databinding. 
            l.Text = DataBinder.Eval(row.DataItem, this.columnName).ToString();


        }



    }



}