using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebSite.Controllers
{
    public class StudentresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addstudent(Student student)
        {

            return View(student);
        }
    }
}
