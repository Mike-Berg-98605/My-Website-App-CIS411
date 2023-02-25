using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteApp.Areas.Admin.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {        
        public IActionResult Page1()
        {
            return View();
        }
       
        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Page3()
        {
            return View();
        }
    }
}
