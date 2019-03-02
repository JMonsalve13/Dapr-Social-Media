using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyProjectSM.Models
{
    public class PostModel
    {
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostURL { get; set; }
        public string PostImageURL { get; set; }
        public string PostText { get; set; }
        public bool IsVideo { get; set; }
    }
}