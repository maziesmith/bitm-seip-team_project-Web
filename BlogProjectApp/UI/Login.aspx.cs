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
    public partial class Login : System.Web.UI.Page
    {
        UserManager userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                errMesg.InnerHtml ="Please Login to Write Article";
            
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string userName = loginUserNameTextBox.Text;
            string password = loginPasswordTextBox.Text;
            User user = userManager.GetUserNameAndPassword(userName, password);
            if (userName == user.UserName || password == user.PassWord)
            {
                
                Session["user"] = user;
                if (Session["url"]!= null)
                {
                    Response.Redirect(Session["url"].ToString()); 
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
            }
            else
            {
                msgLabel.Text = "Login Failed";
            }
        }
    }
}