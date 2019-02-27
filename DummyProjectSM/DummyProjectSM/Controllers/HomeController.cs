using DummyProjectSM.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyProjectSM.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationUserManager _userManager;

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

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ActionResult Profile()
        {

            var userId = User.Identity.GetUserId();

            var userEmail = UserManager.GetEmail(userId);

            var model = new UserModel();

            using (var context = new foodiesEntities())
            {
                // Fetch existing entity
                var user = context.DaPrUsers.FirstOrDefault(u => u.UserEmail == userEmail);

                model.UserName = user.UserName;
                model.UserBio = user.UserBio;
                model.ProfilePicURL = user.ProfilePicURL;
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