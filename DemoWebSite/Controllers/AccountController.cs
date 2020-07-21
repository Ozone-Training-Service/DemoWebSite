using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebSite.Utils;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebSite.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignIn(string name, string address, string email)
        {
            // to db


            // email sending code

            EmailSending obj = new EmailSending();

            Random rn = new Random();
            int otp = rn.Next(1000);

            string OTP = otp.ToString();

            string msg = "Your OTP =" + OTP;

            obj.SendEmail(email,msg,"OTP");


            return View();
        }
    }
}