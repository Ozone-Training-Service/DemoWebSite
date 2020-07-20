using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebSite.Controllers
{
    public class StudentController : Controller
    {

        // Action method
        public IActionResult Index()
        {

            string name = "Vsihnu";
        
           
            return View();
        }

        public IActionResult AddStudent()  //        Student/AddStudent
        {
            return View();
        }

        public IActionResult Page2()
        {
            

            ViewBag.Name= "Vishnu Kumar";
            ViewBag.Age = 16;
            ViewBag.Address = "Kollam";


            ViewData["FirstName"] = "Vishnu";
            ViewData["LastName"] = "Kumar";

            return View();
        }


        public string Hello()
        {
            return "Hello";
        }


    }
}