using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyProjectSM.Models
{
    public class CommentModel
    {
        public int UserID { get; set; }
        public string PostID { get; set; }
        public string TXT { get; set; }
    }
}