using DemoWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebSite.Controllers
{
    public class TeacherController:Controller
    {


        public IActionResult Index()
        {

            return View();
        }



        [HttpPost]
        public IActionResult AddTeacher(string name,string dpt)
        {





            ViewBag.Name = name;
            ViewBag.Dpt = dpt;


            return View();
        }
        //

        [HttpPost]
        public IActionResult AddTeacherAgain(Teacher teacher)
        {



           

            return View(teacher);
        }

    }
}
