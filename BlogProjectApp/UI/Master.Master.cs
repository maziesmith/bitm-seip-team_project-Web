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
    public partial class Master : System.Web.UI.MasterPage
    {
        ArticleManager articleManager = new ArticleManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Article> recentArticleList = articleManager.RecentArticle();


            List<Article> customArticlList = new List<Article>();
            foreach (Article article in recentArticleList)
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
                if (length > 80)
                {
                    length = 80;
                }

                string customDescription = strippedDescription.Substring(0, length);
                customArticle.Description = customDescription;
                customArticle.Title = article.Title;
                customArticlList.Add(customArticle);
            }

            AllRecentPost.DataSource = recentArticleList;
            AllRecentPost.DataBind();



            List<Article> mostViewArticleList = articleManager.MostViewArticle();


            List<Article> customMostViewArticlList = new List<Article>();
            foreach (Article article in mostViewArticleList)
            {
                Article customMostViewArticle = new Article();
                customMostViewArticle.Id = article.Id;

                string source = article.Description;
                var reg = new Regex("src=(?:\"|\')?(?<imgSrc>[^>]*[^/].(?:jpg|bmp|gif|png))(?:\"|\')?");
                var match = reg.Match(source);
                if (match.Success)
                {
                    string encod = match.Groups["imgSrc"].Value;
                    customMostViewArticle.Image = encod;
                }

                string strippedDescription = Regex.Replace(article.Description, "<.*?>", string.Empty);
                int length = strippedDescription.Length;
                if (length > 80)
                {
                    length = 80;
                }

                string customDescription = strippedDescription.Substring(0, length);
                customMostViewArticle.Description = customDescription;
                customMostViewArticle.Title = article.Title;
                customMostViewArticlList.Add(customMostViewArticle);
            }

            mostViewed.DataSource = customMostViewArticlList;
            mostViewed.DataBind();


        }
    }
}