using DummyProjectSM.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.IO;
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

            string email = User.Identity.GetUserName();

            if (email.Equals(""))
            {
                return View("../Account/Login");
            }

            var userId = User.Identity.GetUserId();

            var userEmail = UserManager.GetEmail(userId);

            var model = new UserModel();

            using (var context = new foodiesEntities1())
            {
                // Fetch existing entity
                var user = context.DaPrUsers.FirstOrDefault(u => u.UserEmail == userEmail);

                model.UserName = user.UserName;
                model.UserBio = user.UserBio;
                model.ProfilePicURL = user.ProfilePicURL;
            }

            return View(model);

        }

        public ActionResult Gallery(PostModel model)
        {

            var userId = User.Identity.GetUserId();

            var userEmail = UserManager.GetEmail(userId);

            var model2 = new UserPostsModel();

            List<Post> postList = null;

            // Use EF to get MemeModels from the Database
            // Unit of Work
            using (var context = new foodiesEntities1())
            {
                var user = context.DaPrUsers.FirstOrDefault(m => m.UserEmail == userEmail);

                // Fetch the Meme Entities!
                postList = context.Posts.Where(m => m.UserID == user.UserID).ToList();
            }

            if (postList != null)
            {
                // Convert Meme Entities to Meme Models
                foreach (var post in postList)
                {
                    model2.UserPosts.Add(new PostModel()
                    {
                        PostID = post.PostID,
                        PostTitle = post.PostTitle,
                        PostURL = post.PostURL,
                        IsVideo = post.IsVideo
                    });
                }
            }

            return View(model2);
        }

        [HttpGet]
        public ActionResult Post()
        {
            string email = User.Identity.GetUserName();

            if (email.Equals(""))
            {
                return View("../Account/Login");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Post(HttpPostedFileBase file, PostModel model)
        {
            var userId = User.Identity.GetUserId();

            var userEmail = UserManager.GetEmail(userId);

            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    file.SaveAs(_path);

                    using (var context = new foodiesEntities1())
                    {

                        var user = context.DaPrUsers.FirstOrDefault(m => m.UserEmail == userEmail);

                        var postToMake = new Post();

                        postToMake.PostTitle = model.PostTitle;

                        postToMake.PostURL = "../UploadedFiles/" + _FileName;

                        if (postToMake.PostURL.EndsWith("mp4") || postToMake.PostURL.EndsWith("gif"))
                        {
                            postToMake.IsVideo = true;
                        }
                        else
                        {
                            postToMake.IsVideo = false;
                        }

                        postToMake.UserID = user.UserID;

                        context.Posts.Add(postToMake);
                        context.SaveChanges();
                    };
                }

                return RedirectToAction("Gallery");
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }

        }

        public ActionResult PostDetail(int id)
        {
            Post post = null;
            using (var context = new foodiesEntities1())
            {
                post = context.Posts.FirstOrDefault(m => m.PostID == id);
            }

            if (post == null) return null;

            // Map from Meme Entity to View Model
            var model = new PostModel()
            {
                PostID = post.PostID,
                PostURL = post.PostURL,
                PostTitle = post.PostTitle,
                IsVideo = post.IsVideo,
            };

            return View(model);
        }

        public RedirectToRouteResult Delete(int id)
        {
            using (var context = new foodiesEntities1())
            {
                // Delete from meme where memeid = id
                // Fetch the entity to delete, and remove it from the DBSet
                var thePostToDelete = context.Posts.FirstOrDefault(m => m.PostID == id);


                if (thePostToDelete != null)
                {
                    // Fetch Associated Comments, so we can delete them!
                    var comments = thePostToDelete.Comments.ToList();

                    foreach (var comment in comments)
                    {
                        context.Comments.Remove(comment);
                    }

                    // Actually Delete All Comments
                    context.SaveChanges();

                    // Delete the meme itself
                    context.Posts.Remove(thePostToDelete);
                    // REMEMBER this!
                    context.SaveChanges();
                }
            }
            return RedirectToAction("Gallery");
            //return View("MemeList");
        }

        public ActionResult Update(int id)
        {
            var model = new PostModel();

            using (var context = new foodiesEntities1())
            {
                var post = context.Posts.FirstOrDefault(m => m.PostID == id);

                model.PostTitle = post.PostTitle;
                model.PostURL = post.PostURL;
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(int id, PostModel model)
        {
            using (var context = new foodiesEntities1())
            {
                // Fetch existing entity
                var thePostToUpdate = context.Posts.FirstOrDefault(m => m.PostID == id);

                // Update entity based on model
                thePostToUpdate.PostTitle = model.PostTitle;

                // Save Changes
                context.SaveChanges();


            }

            var model2 = new UserPostsModel();

            List<Post> postList = null;

            // Use EF to get MemeModels from the Database
            // Unit of Work
            using (var context = new foodiesEntities1())
            {
                // Fetch the Meme Entities!
                postList = context.Posts.Select(m => m).ToList();
            }

            if (postList != null)
            {
                // Convert Meme Entities to Meme Models
                foreach (var post in postList)
                {
                    model2.UserPosts.Add(new PostModel()
                    {
                        PostID = post.PostID,
                        PostTitle = post.PostTitle,
                        PostURL = post.PostURL
                    });
                }
            }
            return RedirectToAction("Gallery");
        }
    } 
}