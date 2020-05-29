using Mukicik_backend.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik_backend.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }
        protected void userClick_registerButton(object sender, EventArgs e)
        {

            if (input_userPassword.Text == input_repeatUserPassword.Text)
            {

                string
                    userName = input_userName.Text,
                    email = input_userEmailAddress.Text,
                    password = input_userPassword.Text,
                    gender = null,
                    userDOB = input_userDOB.Text,
                    userRole = input_role.Text,
                    userImage = input_userPP.Text;

                if (Chk_Female.Checked) gender = "female";
                if (Chk_Male.Checked) gender = "male";

                userRepository.createUser(userName, email, password, gender, userDOB, userRole, userImage);
                labelError.Text = "Registration success!";
                labelError.Visible = true;
            }
            else
            {
                labelError.Text = "Password does not match!";
                labelError.Visible = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = Calendar1.SelectedDate;
            input_userDOB.Text = date.ToString("dd/MM/yyyy");
        }
    }
}