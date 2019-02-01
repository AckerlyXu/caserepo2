using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCases.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
 
        public ActionResult Pdf()
        {
            return File(Server.MapPath("/abc.pdf"), "application/pdf");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Partial(string userId)
        {
            return PartialView("Partial", userId);
        }

       public String TestExtension()
        {
         string a =   "abaaaaaaaaaaaaaa.jpg".Substring(("abaaaaaaaaaaaaaa.jpg".Length -4), 4);
            
            return a;
        }
    }
}