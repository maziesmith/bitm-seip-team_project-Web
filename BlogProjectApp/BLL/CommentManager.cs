using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogProjectApp.DAL;
using BlogProjectApp.MODEL;

namespace BlogProjectApp.BLL
{
    public class CommentManager
    {
        CommentGateway commentGateway = new CommentGateway();
        public void CommentArticle(ArticleComment articleComment)
        {
            commentGateway.CommentArticle(articleComment);
        }

        public List<ArticleComment> AllCommentByArticleId(string articleId)
        {
            return commentGateway.AllCommentByArticleId(articleId);
        }
    }
}