using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogProjectApp.BLL;
using BlogProjectApp.MODEL;

namespace BlogProjectApp.UI
{
    public partial class MyArticles : System.Web.UI.Page
    {
        ArticleManager aArticleManager = new ArticleManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Article> articleList = aArticleManager.GetArticleList();

            List<Article> customArticlList = new List<Article>();
            foreach (Article article in articleList)
            {
                Article customArticle = new Article();
                customArticle.Id = article.Id;

                string source = article.Description;
                var reg = new Regex("src=(?:\"|\')?(?<imgSrc>[^>]*[^/].(?:jpg|bmp|gif|png))(?:\"|\')?");
                var match = reg.Match(source);
                if (match.Success)
                {
                    string encod = match.Groups["imgSrc"].Value;
                    customArticle.Image = encod;
                }

                string strippedDescription = Regex.Replace(article.Description, "<.*?>", string.Empty);
                int length = strippedDescription.Length;
                if (length > 200)
                {
                    length = 200;
                }

                string customDescription = strippedDescription.Substring(0, length);
                customArticle.Description = customDescription;
                customArticle.Title = article.Title;
                customArticlList.Add(customArticle);
            }

            AllPost.DataSource = customArticlList;
            AllPost.DataBind();


        }
    }
}