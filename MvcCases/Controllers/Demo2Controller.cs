using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}