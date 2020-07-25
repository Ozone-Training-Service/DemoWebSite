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

        public IActionResult TeacherList()
        {
            // from db  get Teacherlist


            // Dummy data

            List<Teacher> teacherList = new List<Teacher>();
            teacherList.Add(new Teacher() {Id=1,Name="Aji",Department="physics",MobileNumber="9909089",Address="Thrissur" });

            teacherList.Add(new Teacher() { Id = 2, Name = "Vishnu", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });

            teacherList.Add(new Teacher() { Id = 3, Name = "VishnuKumar", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });
            teacherList.Add(new Teacher() { Id = 1, Name = "Aji", Department = "physics", MobileNumber = "9909089", Address = "Thrissur" });

            teacherList.Add(new Teacher() { Id = 2, Name = "Vishnu", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });

            teacherList.Add(new Teacher() { Id = 3, Name = "VishnuKumar", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });

            teacherList.Add(new Teacher() { Id = 1, Name = "Aji", Department = "physics", MobileNumber = "9909089", Address = "Thrissur" });

            teacherList.Add(new Teacher() { Id = 2, Name = "Vishnu", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });

            teacherList.Add(new Teacher() { Id = 3, Name = "VishnuKumar", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });
            teacherList.Add(new Teacher() { Id = 1, Name = "Aji", Department = "physics", MobileNumber = "9909089", Address = "Thrissur" });

            teacherList.Add(new Teacher() { Id = 2, Name = "Vishnu", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });

            teacherList.Add(new Teacher() { Id = 3, Name = "VishnuKumar", Department = "Chemistry", MobileNumber = "8989878", Address = "Kollam" });
          
            
            return View(teacherList);
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
