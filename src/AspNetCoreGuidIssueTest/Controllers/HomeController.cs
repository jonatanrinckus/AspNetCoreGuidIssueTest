using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreGuidIssueTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreGuidIssueTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var test = new Test()
            {
                AnotherGuidId = new Guid("4689d77b-a373-450d-a7e6-3394b557ce31")
            };
            return View(test);
        }

        public IActionResult Edit(Guid id)
        {
            var test = new Test()
            {
                AnotherGuidId = id
            };
            return View(test);
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
