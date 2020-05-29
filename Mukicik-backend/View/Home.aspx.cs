using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik_backend.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userSession"] != null)
            {
                label_userSession.Text = "Logged in as : " + Session["userSession"].ToString();
                placeholder_userSession.Visible = true;
                if (Session["userCart"] != null)
                {
                    label_userCart.Text = "UserCart : " + Session["userCart"].ToString();
                    placeholder_userCart.Visible = true;
                } else placeholder_userCart.Visible = false;
            }
            else placeholder_userSession.Visible = false;       
        }
        protected void userClick_logoutButton(object sender, EventArgs e)
        {
            Session["userSession"] = null;
            Session.Clear();
            Response.Cookies.Clear();
            Response.Cache.SetNoStore();
            Response.CacheControl = "no-cache";
            Response.Redirect("Home.aspx");
        }
    }
}