using ConsoleApp1;
using MvcCases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcCases.Controllers
{
    public class Demo2Controller : Controller
    {
        // GET: Demo2
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username)
        {
            if (username != null)
            {
                Session["username"] = username;
            }
         
            return View();
        }
        [HttpPost]
        public ActionResult GetArray(string vara, string[] varb)
        {
            return Json(new { vara,varb}, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetPCount()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ShowTS()
        {
           
            
            TeacherAndStudent teacherAndStudent = new TeacherAndStudent();
            teacherAndStudent.Students = new List<Student>();
            teacherAndStudent.Teachers = new List<Teacher>();

            teacherAndStudent.Students.Add (new Student());

            teacherAndStudent.Students.Add(new Student());


            teacherAndStudent.Teachers.Add(new Teacher());
            teacherAndStudent.Teachers.Add(new Teacher());
            
            return View(teacherAndStudent);
        }
        
        public ActionResult  SelfJoin()
        {
            AdminDbcontext context = new AdminDbcontext();
           List<MyViewModel> query =   context.AdminSection_GENs.GroupJoin(context.AdminSection_GENs, first => first.BintId_Pk, second => second.IntParentId_FK, (first, second) =>
               new {a=first, b=second} // b is a collection which belongs to a 
         
             ).SelectMany(
                       x => x.b.DefaultIfEmpty(),
                       (x, y) => new  MyViewModel{ AbinId_Pk= x.a.BintId_Pk,AViewTitle=x.a.ViewTitle,BViewTitle=y.ViewTitle  }
                       )
             
             .OrderBy(e=>e.AbinId_Pk).ToList();

            return View(query);
        }

        //MyDbContext context = new MyDbContext();
        //Database.SetInitializer(new CreateDatabaseIfNotExists<MyDbContext>());
        //    context.Database.Initialize(false);
        //https://forums.asp.net/t/2154842.aspx
        [HttpPost]
        public ActionResult CreateTeacherAndStudent(TeacherAndStudent teacherAndStudent)
        {
            try
            {
                MyDbContext context = new MyDbContext();
                context.Teachers.AddRange(teacherAndStudent.Teachers);
                context.Students.AddRange(teacherAndStudent.Students);
                context.SaveChanges();
                return Content("save ok");
            }
            catch (Exception)
            {

                return View("ShowTS", teacherAndStudent);
            }
           
        }


        public   ActionResult GetData()
        {

            return View(new MyModel { Total = "3"});
          
        }
        
    }
    public class MyModel
    {
        [DisplayFormat(DataFormatString = "{0:2}", ApplyFormatInEditMode = true,NullDisplayText ="0.00")]
        public string Total { get; set; }
    }
    public class MyViewModel
    {
        public int AbinId_Pk { get; set; }
        public string AViewTitle { get; set; }
        public string BViewTitle { get; set; }
    }
}