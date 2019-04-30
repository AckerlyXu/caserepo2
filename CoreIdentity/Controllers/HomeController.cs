using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreIdentity.Models;
using System.Security.Claims;

namespace CoreIdentity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var identity = principal.Identities.FirstOrDefault(x => x.IsAuthenticated);
            if (identity == null) return Task.FromResult(principal);

            var user = identity.Name;
            if (user == null) return Task.FromResult(principal);


           // ((ClaimsIdentity)principal.Identity).AddClaim(new Claim("Code",));
            return Task.FromResult(principal);
        }
    }
}
