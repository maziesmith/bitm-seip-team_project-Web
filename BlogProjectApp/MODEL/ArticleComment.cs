using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProjectApp.MODEL
{
    public class ArticleComment
    {
        public string CommentUserName { get; set; }
        public string CommentDescription { get; set; }
        public string CommentArticleId { get; set; }
        public string Date { get; set; }
    }
}