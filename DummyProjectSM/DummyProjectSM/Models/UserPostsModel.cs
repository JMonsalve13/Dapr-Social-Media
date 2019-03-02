using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyProjectSM.Models
{
    public class UserPostsModel
    {
            public List<PostModel> UserPosts { get; set; }

            public UserPostsModel()
            {
                UserPosts = new List<PostModel>();
            }
    }
}