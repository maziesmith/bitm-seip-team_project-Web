using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogProjectApp.BLL;
using BlogProjectApp.MODEL;

namespace BlogProjectApp.UI
{
    public partial class DetailBlog : System.Web.UI.Page
    {
        CommentManager commentManager = new CommentManager();
        Article article = new Article();
        ArticleManager articleManager = new ArticleManager();
       // ArticleComment articleComment = new ArticleComment();
        protected void Page_Load(object sender, EventArgs e)
        {
                    string articleID = Request.QueryString["articleId"];

            articleManager.HitArticleSave(articleID);
            List<ArticleComment> articleComments = commentManager.AllCommentByArticleId(articleID);
            showAllComment.DataSource = articleComments;
            showAllComment.DataBind();
           
            List<Article> aArticleList = articleManager.GetDetailArticle(articleID);

            detailPost.DataSource = aArticleList;
            detailPost.DataBind();

        }

        protected void detailPost_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            string articleID = Request.QueryString["articleId"];

            User aUser = (User)Session["user"];

            ArticleComment articleComment = new ArticleComment();
            articleComment.CommentUserName = aUser.UserName;
            articleComment.CommentDescription = Request.Form["commentDescription"];
            articleComment.CommentArticleId = articleID;

            commentManager.CommentArticle(articleComment);
        }

        protected void commentButton_Click(object sender, EventArgs e)
        {
             string articleID = Request.QueryString["articleId"];

            User aUser = (User)Session["user"];

            ArticleComment articleComment = new ArticleComment();
            articleComment.CommentUserName = aUser.UserName;
            articleComment.CommentDescription = Request.Form["commentDescription"];
            articleComment.CommentArticleId = articleID;

            commentManager.CommentArticle(articleComment);
        }
    }
}