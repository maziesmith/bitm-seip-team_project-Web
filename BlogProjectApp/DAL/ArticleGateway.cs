using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BlogProjectApp.MODEL;

namespace BlogProjectApp.DAL
{
    public class ArticleGateway
    {
        private string dbConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public int Save(Article article)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "INSERT INTO tbl_article(title,description,status,date,user_name,article_hit_count) VALUES ('" + article.Title +
                           "','" +
                           article.Description + "','" + article.Status + "','" + DateTime.Now + "','" + article.PostUserName + "','0')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowA = command.ExecuteNonQuery();
            connection.Close();
            return rowA;
        }

        public List<Article> GetArticleList()
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "SELECT TOP(5) * FROM tbl_article ORDER BY id DESC";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Article> articleList = new List<Article>();

            while (reader.Read())
            {
                Article article = new Article();
                article.Id = int.Parse(reader["id"].ToString());
                article.Title = reader["title"].ToString();
                article.Description = reader["description"].ToString();
                article.Date = reader["date"].ToString();
                article.PostUserName = reader["user_name"].ToString();

                articleList.Add(article);
            }
            reader.Close();
            connection.Close();

            return articleList;

        }

        public List<Article> GetDetailArticle(string articleId)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "SELECT * FROM tbl_article WHERE id = '" + articleId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Article> articleList = new List<Article>();

            while (reader.Read())
            {
                Article article = new Article();
                article.Id = int.Parse(reader["id"].ToString());
                article.Title = reader["title"].ToString();
                article.PostUserName = reader["user_name"].ToString();
                article.Description = reader["description"].ToString();
                article.Date = reader["date"].ToString();

                article.ArticleHitCount = int.Parse(reader["article_hit_count"].ToString());

                articleList.Add(article);
            }
            reader.Close();
            connection.Close();

            return articleList;
        }

        public void HitArticleSave(string articleId)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "UPDATE tbl_article SET article_hit_count += '1'  WHERE id = '" + articleId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Article> RecentArticle()
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "SELECT TOP(5) * FROM tbl_article ORDER BY date DESC";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Article> articleList = new List<Article>();

            while (reader.Read())
            {
                Article article = new Article();
                article.Id = int.Parse(reader["id"].ToString());
                article.Title = reader["title"].ToString();
                article.Description = reader["description"].ToString();
                article.Date = reader["date"].ToString();
                article.PostUserName = reader["user_name"].ToString();

                articleList.Add(article);
            }
            reader.Close();
            connection.Close();

            return articleList;
        }

        public List<Article> MostViewArticle()
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "SELECT TOP(5) * FROM tbl_article  ORDER BY article_hit_count DESC ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Article> articleList = new List<Article>();

            while (reader.Read())
            {
                Article article = new Article();
                article.Id = int.Parse(reader["id"].ToString());
                article.Title = reader["title"].ToString();
                article.Description = reader["description"].ToString();
                article.Date = reader["date"].ToString();
                article.PostUserName = reader["user_name"].ToString();

                articleList.Add(article);
            }
            reader.Close();
            connection.Close();

            return articleList;
        }
    }
}