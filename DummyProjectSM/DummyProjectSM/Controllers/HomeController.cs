using DummyProjectSM.Models;
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
        public ActionResult Index()
        {
            string email = User.Identity.GetUserName();

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
            int id = 1;

            var model = new UserModel();

            using (var context = new foodiesEntities())
            {
                // Fetch existing entity
                var user = context.DaPrUsers.FirstOrDefault(u => u.UserID == id);

                model.UserName = user.UserName;
                model.UserBio = user.UserBio;
                model.ProfilePicURL = "../UploadedFiles/ansponge.jpg";
            }

            string email = User.Identity.GetUserName();

            if (email.Equals(""))
            {
                return View("../Account/Login");
            }
            else
            {
                return View(model);
            }

        }
    }
}