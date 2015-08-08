using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BlogProjectApp.MODEL;

namespace BlogProjectApp.DAL
{
    public class CommentGateway
    {
        private string dbConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public void CommentArticle(ArticleComment articleComment)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "INSERT INTO tbl_comment(user_name,article_id,comment_description,date) VALUES ('" + articleComment.CommentUserName +
                           "','" +
                           articleComment.CommentArticleId + "','" + articleComment.CommentDescription + "','" + DateTime.Now + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            
            
        }

        public List<ArticleComment> AllCommentByArticleId(string articleId)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "SELECT * FROM tbl_comment WHERE article_id = '"+articleId+"' ORDER BY id DESC";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<ArticleComment> commentList = new List<ArticleComment>();

            while (reader.Read())
            {
                ArticleComment comment = new ArticleComment();
                comment.CommentArticleId = reader["id"].ToString();
                comment.CommentUserName = reader["user_name"].ToString();
                comment.CommentDescription = reader["comment_description"].ToString();
                comment.Date = reader["date"].ToString();
                commentList.Add(comment);
            }
            reader.Close();
            connection.Close();

            return commentList;
        }
    }
}