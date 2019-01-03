using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mail;
using System.Web.Mvc;
using TheNorthernHandyManReDone11_3_18.Models;

namespace TheNorthernHandyManReDone11_3_18.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult flooring()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult SendEmail(string Name, string Phone, string Message, string Email, string Subject)
        {

            var passWord = "northernhandyman";
            var email = new MailAddress("thenorthernhandyman@gmail.com", "Jeff");

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(email.Address, passWord)
            };

            using (var mess = new System.Net.Mail.MailMessage(email, email)
            {
                Subject = Subject,
                Body = "From: " + Name + "\n Phone Number: " + Phone + "\n Job Description: " + Message + "\n Email: " + Email
            })
            {
                smtp.Send(mess);
            }




            //System.Web.Mail.SmtpMail.SmtpServer = "relay-hosting.secureserver.net";
            //SmtpMail.Send(emailmessage);
            MessageBox("Email sent successfully!");


            return new EmptyResult();
        }

        public ActionResult Contact(ContactEmailModels e)
        {
            string ValidationMessage = String.Empty;

            ViewBag.Name = String.Empty;
            ViewBag.Email = String.Empty;
            ViewBag.Phone = String.Empty;
            ViewBag.Message = String.Empty;


            if (!String.IsNullOrEmpty(e.Name) && !String.IsNullOrEmpty(e.Message) && !String.IsNullOrEmpty(e.Phone) && !String.IsNullOrEmpty(e.Email))
            {
                var emailmessage = new System.Web.Mail.MailMessage()
                {
                    Subject = e.Name,
                    Body = "From: " + e.Name + "\n Phone Number: " + e.Phone + "\n Job Description: " + e.Message + "\n Email: " + e.Email,
                    From = "thenorthernhandyman@thenorthernhandyman.org",
                    To = "thenorthernhandyman@gmail.org",
                    BodyFormat = MailFormat.Text,
                    Priority = System.Web.Mail.MailPriority.High
                };
                var passWord = "northernhandyman";
                var email = new MailAddress("thenorthernhandyman@gmail.com", "Jeff");

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(email.Address, passWord)
                };

                using (var mess = new System.Net.Mail.MailMessage(email, email)
                {
                    Subject = e.Name,
                    Body = "From: " + e.Name + "\n Phone Number: " + e.Phone + "\n Job Description: " + e.Message + "\n Email: " + e.Email
                })
                {
                    smtp.Send(mess);
                }




                //System.Web.Mail.SmtpMail.SmtpServer = "relay-hosting.secureserver.net";
                //SmtpMail.Send(emailmessage);
                MessageBox("Email sent successfully!");
                //return RedirectToAction("Index", "Home", null);

            }

            return View(e);
        }
        public EmptyResult MessageBox(string s)
        {
            Response.Write("<script type=\"text/javascript\">alert('" + s + "');</script>");
            return null;
        }

        public ActionResult Services()
        {
            return View();
        }
       
        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult FireWood()
        {
            return View();
        }

        public ActionResult Employment()
        {
            return View();
        }

        public ActionResult Albums()
        {
            return View();
        }
        public ActionResult FloridaHomePage()
        {
            return View();
        }



    }
    //public ActionResult 
}
