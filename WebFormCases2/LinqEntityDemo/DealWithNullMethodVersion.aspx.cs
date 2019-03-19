using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static WebFormCases2.LinqEntityDemo.DealWithNullInLinq;

namespace WebFormCases2.LinqEntityDemo
{
    public partial class DealWithNullMethodVersion : System.Web.UI.Page
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
            List<Grade> gList = new List<Grade> { new Grade { GName = "first grade", Gid = 5 } };
            //  gList = null;
            var query = sList.AsParallel().AsOrdered().Where(stu => stu != null)  // make sList AsParallel
                                                                                  // call join method

                    .GroupJoin(gList == null ? new List<Grade>().AsParallel().AsOrdered() : gList.Where(g => g != null).AsParallel().AsOrdered()
                    // the first parameter is the collection you want to join ,  deal with null value and make the gList as parallel
                    , stu => stu.Gid,  // return the column of student  to join  , here I want to compare Gid, so I return gid
                    grade => grade.Gid,// return the column of grade  to join  , here I want to compare Gid, so I return gid
                    (stu, grade) =>  // stu is student , grade is a collection of grade , if empty it will return an empty retult , you could set a breakpoint to have a look
                      new
                      {
                          stu,
                          grade

                      }
                    ).SelectMany(
                       x => x.grade.DefaultIfEmpty(),
                       (x, y) => new { stu = x.stu, grade = y }
                       );
           var list = query.ToList();
            
        }
    }
}