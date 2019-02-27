using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyProjectSM.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserBio { get; set; }
        public string ProfilePicURL { get; set; }
    }
}