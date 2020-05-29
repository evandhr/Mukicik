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
        public static void createUser(string name, string email, string password, string gender, string DOB, string role, string pp)
        {
            User newUser = userFactory.generateUser(name, email, password, gender, DOB, role, pp);
            Database1Entities db = new Database1Entities();

            db.Users.Add(newUser);
            db.SaveChanges();
        }
        public static User getUserID(string name)
        {
            using (Database1Entities db = new Database1Entities())
            {
                var temp = (from x in db.Users where x.userName == name select x).ToList();
                return temp[0];
            }
        }
    }
}