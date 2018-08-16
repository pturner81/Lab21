using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        List<UserInfo> users = new List<UserInfo>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RegistrationPage()
        {
            ViewBag.Message = "Register Here";

            return View();
        }
        public ActionResult AddUser(UserInfo newUser)
        {
            List<UserInfo> users = new List<UserInfo>();
            //NEEDS VALIDATION
            if (ModelState.IsValid)
            {
                //NEEDS to send data to database
                users.Add(newUser);

                //NEEDS confirmation || send user to index page || sign them in etc.

                ViewBag.ConfMessage = "Thanks " + newUser.FirstName + "!";

                ViewBag.users = users;

                return View();
            }
            else
            {
                return View("Error");
            }
        }
        public ActionResult Users()
        {
            ViewBag.Message = "Users";

            ViewBag.users = users;

            return View();
        }
    }
}