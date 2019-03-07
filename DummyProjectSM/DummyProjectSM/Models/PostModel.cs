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

        static int TITLELIMIT = 100;
        static int URLLIMIT = 500;
        static int IMAGEURLLIMIT = 500;
        static int TEXTLIMIT = 3000;

        public bool IsValid()
        {
            if (!IsUnderTitleLimit())
                return false;
            if (!IsUnderPostURLLimit())
                return false;
            if (!IsUnderImageURLLimit())
                return false;
            if (!IsUnderTextLimit())
                return false;

            return true;
        }

        public bool IsUnderTitleLimit()
        {
            if (PostTitle.Length > TITLELIMIT)
                return false;
            return true;
        }

        public bool IsUnderPostURLLimit()
        {
            if (PostURL.Length > URLLIMIT)
                return false;
            return true;
        }

        public bool IsUnderImageURLLimit()
        {
            if (PostImageURL.Length > IMAGEURLLIMIT)
                return false;
            return true;
        }

        public bool IsUnderTextLimit()
        {
            if (PostText.Length > TEXTLIMIT)
                return false;
            return true;
        }

        public static bool IsUnderTitleLimit(String s)
        {
            if (s.Length > TITLELIMIT)
                return false;
            return true;
        }

        public static bool IsUnderPostURLLimit(String s)
        {
            if (s.Length > URLLIMIT)
                return false;
            return true;
        }

        public static bool IsUnderImageURLLimit(String s)
        {
            if (s.Length > IMAGEURLLIMIT)
                return false;
            return true;
        }

        public static bool IsUnderTextLimit(String s)
        {
            if (s.Length > TEXTLIMIT)
                return false;
            return true;
        }
    }
}