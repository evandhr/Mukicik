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
        protected static Database1Entities db = new Database1Entities();
        public static void createTransaction(int userID)
        {
            Transaction nt = transactionFactory.generateTransaction(userID);
            db.Transactions.Add(nt);
            db.SaveChanges();

        }

        public static List<Transaction> GetTransactions(int userID)
        {
            List<Transaction> lt = db.Transactions.Where(x => x.userID == userID).Select(x => x).ToList();
            return lt;
        }

        public static int getTransactionID(int userID)
        {
            return (from x in db.Transactions where x.userID == userID select x.transactionID).FirstOrDefault();
        }
    }
}