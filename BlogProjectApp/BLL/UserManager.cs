using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogProjectApp.DAL;
using BlogProjectApp.MODEL;

namespace BlogProjectApp.BLL
{
    public class UserManager
    {
        UserGateway userGateway = new UserGateway();
        public User GetUserNameAndPassword(string userName, string password)
        {
            return userGateway.GetUserNameAndPassword(userName, password);
        }

        public string Save(User user)
        {
            if (userGateway.Save(user) > 0)
            {
                return "<span style='color:green'>Registration Success</span>";
            }
            else
            {
                return "<span style='color:red'>Registration Failed!</span>";
            }
            
        }
    }
}