using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebSite.Utils;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebSite.Controllers
{
    public class SignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signin(String name,string msg,string email)
        {
            EmailSending obj = new EmailSending();
            obj.SendEmail(email, msg, "Demo");
            return View();
        }
    }
}
