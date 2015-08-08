using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProjectApp.MODEL
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }

        public string Date { get; set; }
        public string PostUserName { get; set; }
        public int ArticleHitCount { get; set; }

        public int CommentCount { get; set; }
    }
}