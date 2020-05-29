using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Factory
{
    public class userFactory
    {
        public static User generateUser(string userName, string userEmail, string userPassword, string userGender, string userDOB, string userRole, string userProfilePicture)
        {
            User gu = new User();
            gu.userName = userName;
            gu.userEmail = userEmail;
            gu.userPassword = userPassword;
            gu.userGender = userGender;
            gu.userDOB = userDOB;
            gu.userRole = userRole;
            gu.userProfilePicture = userProfilePicture;
            return gu;
        }
    }
}