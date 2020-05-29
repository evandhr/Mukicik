using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Factory
{
    public class transactionFactory
    {
        public static Transaction generateTransaction(DateTime transactionDate, int userID)
        {
            Transaction gt = new Transaction();
            gt.transactionDate = transactionDate;
            gt.userID = userID;
            return gt;
        }
    }
}