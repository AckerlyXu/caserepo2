using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.Models
{
    public partial class MutipleContextDealWithOneToManyCauseException : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // DepartAndEmp dae1 = new DepartAndEmp();
           // DepartAndEmp dae2 = new DepartAndEmp();
           // Department department = new Department() { department_name = "football" };

           // Employee employee =  dae1.employees.Find(1);
           // employee.name = "mijk";

           //department.employees.Add(employee);

            

           // dae2.Entry(department).State = System.Data.Entity.EntityState.Added;
          //  dae2.Entry(employee).State = System.Data.Entity.EntityState.Modified;
         
            //dae2.SaveChanges();
       

        }
    }
}