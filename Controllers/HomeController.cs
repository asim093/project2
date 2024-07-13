using System.Diagnostics;

using landingpage.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace landingpage.Controllers
{
    public class HomeController : Controller
    {

        [Authorize(Roles = "user")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("role") == "user")
            {
                return View();
            }
            else
            {
                return RedirectToAction("login", "admin");
            }
            }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult blog()
        {
            return View();
        }

      


    }
}