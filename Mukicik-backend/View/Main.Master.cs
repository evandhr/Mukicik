using Mukicik_backend.Model;
using Mukicik_backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik.View
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userSession"] != null)
            {
                privilegeManager();
            } else
            {
                button_login2.Text = "Login";
                button_register.Visible = true;
                button_cart.Visible = false;
                button_edit.Visible = false;
                button_insert.Visible = false;
                button_transactions.Visible = false;
            }
        }

        protected void privilegeManager()
        {
            string userSession = Session["userSession"].ToString();
            int userRole = userRepository.userRoleIdentifier(userSession);

            label_userSession.Text = userSession + "   privelege :  ";
            label_userRole.Text = userRole.ToString();
            button_register.Visible = false;
            button_login2.Text = "Logout";
            button_cart.Visible = true;
            button_transactions.Visible = true;
            if (userRole == 10)
            {
                button_edit.Visible = true;
                button_insert.Visible = true;
            }
            else
            {
                button_edit.Visible = false;
                button_insert.Visible = false;
            }
        }

        protected void button_login2_Click(object sender, EventArgs e)
        {
            if (button_login2.Text == "Logout")
            {
                Session["userSession"] = null;
                Session.Clear();
                Response.Cookies.Clear();
                Response.Cache.SetNoStore();
                Response.CacheControl = "no-cache";
                Response.Redirect("Home.aspx");
            }
            else Response.Redirect("Login.aspx");
        }
    }
}