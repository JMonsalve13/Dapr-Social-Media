using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyProjectSM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string email)
        {
            email = User.Identity.GetUserName();

            if (email.Equals(""))
            {
                return View("../Account/Login");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}