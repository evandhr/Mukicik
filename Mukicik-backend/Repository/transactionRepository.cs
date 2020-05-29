using Mukicik_backend.Factory;
using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Repository
{
    public class transactionRepository
    {
        public static void createTransaction(DateTime date, int userID)
        {
            Database1Entities db = new Database1Entities();
            Transaction nt = transactionFactory.generateTransaction(date, userID);
            db.Transactions.Add(nt);
            db.SaveChanges();

        }
        public static Transaction getTransactionID(int userID)
        {
            using (Database1Entities db = new Database1Entities())
            {
                var temp = (from x in db.Transactions where x.userID == userID select x).ToList();
                return temp[0];
            }
        }
    }
}