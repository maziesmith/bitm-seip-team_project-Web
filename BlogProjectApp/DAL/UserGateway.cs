using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BlogProjectApp.MODEL;

namespace BlogProjectApp.DAL
{
    public class UserGateway
    {
        private string dbConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public User GetUserNameAndPassword(string userName, object passWord)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "SELECT * FROM tbl_users WHERE username = '" + userName + "' AND password = '" +
                           passWord + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            User aUser = new User();

            if (reader.Read())
            {
                aUser.Id = int.Parse(reader["id"].ToString());
                aUser.UserName = reader["username"].ToString();
                aUser.PassWord = reader["password"].ToString();
                aUser.Email = reader["email"].ToString();
                aUser.FullName = reader["fullname"].ToString();
                
            }
            reader.Close();
            connection.Close();

            return aUser;
        }

        public int Save(User user)
        {
            SqlConnection connection = new SqlConnection(dbConnectionString);
            string query = "INSERT INTO tbl_users(username,password,fullname,email,date)VALUES('" + user.UserName + "','" + user.PassWord + "','" +
                           user.FullName + "','" + user.Email + "','" + DateTime.Now + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
             int rowAf = command.ExecuteNonQuery();
            connection.Close();
            return rowAf;
        }
    }
}