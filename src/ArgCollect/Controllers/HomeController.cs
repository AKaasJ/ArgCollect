using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ArgCollect.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to argcollect, the goal of this page is to ... The webpage will present you with a premise which you can agree or disagree with... do you want to participate?";
            ViewData["Statement"] = "Lorem ipsum > bla bla";
            ViewData["Argument"] = "Argument #?";
            

            return View();
        }

        [HttpPost]
        public IActionResult Index(string primerAreaText)
        {
            ViewData["Message"] = "Welcome to argcollect, the goal of this page is to ... The webpage will present you with a premise which you can agree or disagree with... do you want to participate?";
            ViewData["Statement"] = "Lorem ipsum > bla bla";
            ViewData["Argument"] = primerAreaText;


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
            return View();
        }
    }
}
