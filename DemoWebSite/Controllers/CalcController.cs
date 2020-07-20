using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebSite.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Test()
        {

            ViewBag.Anything = "Any value";
            return View();
        }


        [HttpGet]
        public IActionResult Ans(  string n1, string n2)
        {

            string ans = n1 + n2;

            ViewBag.Ans = ans;


            return View();
        }
    }
}