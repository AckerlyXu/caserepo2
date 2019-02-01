using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models.school;

namespace WebFormCases2.GridViewDemo
{
    public partial class ShowEnumType : System.Web.UI.Page
    {
        ServiceDbContext serviceDbContext = new ServiceDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource = serviceDbContext.ServiceConfigurations.ToList();
            //GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = serviceDbContext.ServiceConfigurations.ToList();
            GridView1.DataBind();

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable GridView1_GetData()
        {
            return serviceDbContext.ServiceConfigurations;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridView1_UpdateItem(int id)
        {
            WebFormCases2.Models.school.ServiceConfiguration item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();

            }
        }
    }
}