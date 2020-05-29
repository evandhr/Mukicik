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
        protected static Database1Entities db = new Database1Entities();
        public static void createTransactionDetail(int Quantity, int transactionID, int productID)
        {
            TransactionDetail trd = transactionDetailFactory.generateDetail(Quantity, transactionID, productID);
            db.TransactionDetails.Add(trd);
            db.SaveChanges();
        }

        public static List<TransactionDetail> GetTransactionDetails(int transactionID)
        {
            List<TransactionDetail> ltrd = db.TransactionDetails.Where(x => x.transactionID == transactionID).Select(x => x).ToList();
            return ltrd;
        }

        public static void deleteCartItems(int tdID)
        {
            /* TransactionDetail ltrd = db.TransactionDetails.Where(x => x.detailTransactionID == tdID).Select(x => x).SingleOrDefault(); */
            TransactionDetail ltrd = (from x in db.TransactionDetails where x.productID == tdID select x).SingleOrDefault();
            db.TransactionDetails.Remove(ltrd);
            db.SaveChanges();
        }
        public static TransactionDetail insertCart(int productID, int qty)
        {
            TransactionDetail td = new TransactionDetail();
            td.productID = productID;
            td.Quantity = qty;
            return td;
        }
    }
}