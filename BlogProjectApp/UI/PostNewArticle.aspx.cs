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
    public partial class PostNewArticle : System.Web.UI.Page
    {
        ArticleManager articleManager = new ArticleManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Session["errMsg"] = "Please Log In to write an article";
                Session["url"] = "PostNewArticle.aspx";
                Response.Redirect("Login.aspx");
            }

        }

        protected void postArticle_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.Title = articletitleTextbox.Text;
            article.Description = Request.Form["edit"];
            
            article.Status = Request.Form["status"];
            User sessionUser = (User)Session["user"];
            article.PostUserName = sessionUser.Id.ToString();

            //User aUser = (User)Session["user"];

            //article.PostUserName = aUser.UserName;

            //User aUser = userGateway.GetUserId();
            //article.UserId = aUser.Id;

             msg.InnerHtml = articleManager.Save(article);
            //msg.InnerHtml = "Article Post Success";
        }
    }
}