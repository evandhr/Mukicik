using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Factory
{
    public class transactionFactory
    {
        public static Transaction generateTransaction(int userID)
        {
            Transaction gt = new Transaction();
            gt.transactionDate = DateTime.Now;
            gt.userID = userID;
            return gt;
        }
    }
}