using Mukicik_backend.Model;
using Mukicik_backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik_backend.View
{
    public partial class transactionPage : System.Web.UI.Page
    {
        protected static Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userSession"] != null)
            {
                placeholder_user.Visible = true;
                string userSession = Session["userSession"].ToString();
                if (userRepository.userRoleIdentifier(userSession) != 10)
                {
                    int userID = userRepository.getUserID(userSession);
                    List<Transaction> tr = transactionRepository.GetTransactions(userID);
                    gvTransactionList.DataSource = tr;
                    gvTransactionList.DataBind();

                    int transactionID = transactionRepository.getTransactionID(userID);
                    List<TransactionDetail> trd = transactionDetailRepository.GetTransactionDetails(transactionID);
                    gvTransactionDetail.DataSource = trd;
                    gvTransactionDetail.DataBind();
                } else
                {
                    List<Transaction> tr = (from x in db.Transactions select x).ToList();
                    List<TransactionDetail> trd = (from x in db.TransactionDetails select x).ToList();
                    gvTransactionList.DataSource = tr;
                    gvTransactionList.DataBind();
                    gvTransactionDetail.DataSource = trd;
                    gvTransactionDetail.DataBind();
                }   
            } else placeholder_user.Visible = false;
        }
    }
}