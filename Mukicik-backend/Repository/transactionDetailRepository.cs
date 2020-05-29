using Mukicik_backend.Factory;
using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Repository
{
    public class transactionDetailRepository
    {
        public static void createTransactionDetail(int Quantity, int transactionID, int productID)
        {
            Database1Entities db = new Database1Entities();
            transactionDetailFactory trd = transactionDetailFactory.generateDetail(Quantity, transactionID, productID);
            db.TransactionDetails.Add(trd);
            db.SaveChanges();
        }
    }
}