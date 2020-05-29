using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mukicik_backend.Factory;
using System.Data.Entity.Validation;

namespace Mukicik_backend.Repository
{
    public class userRepository
    {
        protected static Database1Entities db = new Database1Entities();
        public static void createUser(string name, string email, string password, string gender, string DOB, string role, string pp)
        {
            User newUser = userFactory.generateUser(name, email, password, gender, DOB, role, pp);

            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public static int getUserID(string userName)
        {
            return db.Users.Where(x => x.userName == userName).Select(x => x.userID).FirstOrDefault();
        }
        public static int userRoleIdentifier(string userSession)
        {
            string userRole = (from x in db.Users where x.userName == userSession select x.userRole).FirstOrDefault();
            if (userRole == "Admin") return 10;
            else if (userRole == "Gold") return 2;
            else if (userRole == "User") return 1;
            else return 0;
        }
    }
}