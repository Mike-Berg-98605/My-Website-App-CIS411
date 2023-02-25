using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Phone = "555-123-4567";
            ViewBag.Email = "me@me.com";
            ViewBag.Facebook = "Don't use facebook";

            return View();
        }
    }
}
