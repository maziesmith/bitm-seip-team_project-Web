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
    public partial class Registration : System.Web.UI.Page
    {
        UserManager userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registrationButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FullName = fullNameTextBox.Text;
            user.Email = emailTextBox.Text;
            user.UserName = userNameTextBox.Text;
            user.PassWord = passwordTextBox.Text;

            string sucMess = userManager.Save(user);
            msg.InnerHtml = sucMess;
        }
    }
}