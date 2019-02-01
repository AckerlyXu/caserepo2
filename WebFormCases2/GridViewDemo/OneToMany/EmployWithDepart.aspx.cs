using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormCases2.Models;

namespace WebFormCases2.GridViewDemo.OneToMany
{
    public partial class EmployWithDepart : System.Web.UI.Page
    {
        DepartAndEmp de = new DepartAndEmp();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                //bind employees to the gridview
                GridView1.DataSource = de.employees.ToList();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //write your code
                }
            }
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                //get the employee bound to the current row
              Employee  emp =  e.Row.DataItem as Employee;
                if (emp.department_id.HasValue)
                {
                    //if the employee has department, show the department
                    e.Row.Cells[2].Text = emp.department.department_name;
                }
                else
                {
                    // if the employee doesn't have department, show dropdown list of department
                    DropDownList dropdown = new DropDownList();//create a drropdown
                    dropdown.DataTextField = "department_name";
                    dropdown.DataValueField = "id";
                    List<Department> list =    de.departments.ToList();
                    dropdown.DataSource = list; //bind department to the dropdown
                    dropdown.DataBind();
                    e.Row.Cells[2].Controls.Add(dropdown); //add the dropdown to the row

                }
            }
        }
    }
}