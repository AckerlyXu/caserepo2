using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class DealWithNullInLinq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> sList = new List<Student>
            {
                new Student{Sid=1,Name="David",Gid=3},
                new Student{Sid=2,Name="Nancy",Gid=4},
                new Student{Sid=3,Name="Jerry",Gid=5},
                null
            };
            List<Grade> gList = new List<Grade> { new Grade { GName="first grade",Gid=5} };
          //  gList = null;
            var query =
                from stu in sList.AsParallel().AsOrdered()
                where stu != null
                join grade in gList==null?new List<Grade>().AsParallel().AsOrdered(): gList.Where(g=>g!=null).AsParallel().AsOrdered() 
              
                on stu.Gid equals grade.Gid
                into grp
                from g in grp.DefaultIfEmpty()
                select new { stu.Name, gname=g==null?"":g.GName };
            var data = query.ToList();





        }

        public class Student
        {
            public int Sid { get; set; }
            public string Name { get; set; }
            public int Gid { get; set; }
        }

        public class Grade
        {
            public int Gid { get; set; }
            public string GName { get; set; }
        }
    }
}