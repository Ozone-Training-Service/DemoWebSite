using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebSite.Models;
using DemoWebSite.Utils;
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

            // File writing
            FileWritterUtilcs obj = new FileWritterUtilcs();
            obj.WriteFunction(student);



            return View(student);
        }
    }
}
