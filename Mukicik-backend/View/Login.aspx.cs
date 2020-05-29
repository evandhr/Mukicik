using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mukicik_backend.Model;

namespace Mukicik_backend.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void userClick_loginButton(object sender, EventArgs e)
        {
            string userName = userInput_userName.Text;
            string userPassword = userInput_userPassword.Text;

            Database1Entities db = new Database1Entities();

            User verifyUsername = db.Users.Where(obj => obj.userName == userName).FirstOrDefault();
            User verifyPassword = db.Users.Where(obj => obj.userPassword == userPassword).FirstOrDefault();

            if (verifyUsername == null) userLabel_login.Text = "Username does not exists";
            else if (verifyPassword == null) userLabel_login.Text = "Wrong Password!";

            if (verifyUsername != null && verifyPassword != null)
            {
                Session["userSession"] = verifyUsername.userName;
                Response.Redirect("Home.aspx");
            }

        }
    }
}