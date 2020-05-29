using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Factory
{
    public class transactionDetailFactory
    {
        public static TransactionDetail generateDetail(int Quantity, int transactionID, int productID)
        {
            TransactionDetail gd = new TransactionDetail();
            gd.Quantity = Quantity;
            gd.transactionID = transactionID;
            gd.productID = productID;
            return gd;
        }
    }
}