﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
namespace DemoWebSite.Utils
{
    public class EmailSending
    {

        public void SendEmail(string toAddress, string msg, string subject)
        {


        



            Random rn = new Random();
            int otp = rn.Next(1000);
            string OTP = otp.ToString();


            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("vishnuvis0016@gmail.com"); // From

            mail.To.Add(toAddress);// To
            mail.Subject = subject;
            mail.Body = msg;


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("Vishnuvis0016@gmail.com", "Snakegame005");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
