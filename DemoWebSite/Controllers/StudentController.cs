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

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(int sid, String name, int dob, String address)  //        Student/AddStudent
        {
            ViewBag.sid = sid;
            ViewBag.name = name;
            ViewBag.dob = dob;
            ViewBag.address = address;

            return View();
        }





        //public IActionResult Page2()
        //{
            //ViewBag.Name= "Vishnu Kumar";
            //ViewBag.Age = 16;
            //ViewBag.Address = "Kollam";
            //ViewData["FirstName"] = "Vishnu";
            //ViewData["LastName"] = "Kumar";
            //return View();
        //}


        


    }
}