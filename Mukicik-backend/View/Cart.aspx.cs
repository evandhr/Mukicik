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
    public partial class Cart : System.Web.UI.Page
    {
        private static Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userSession"] != null)
            {
                if (userRepository.userRoleIdentifier(Session["userSession"].ToString()) > 0)
                {
                    placeholder_usercart.Visible = true;
                    loadCart();
                }
                else placeholder_usercart.Visible = false;
            }
        }

        protected void loadCart()
        {
            if (Session["userCart"] != null)
            {
                int total = 0;
                List<TransactionDetail> tempCart = ((List<TransactionDetail>)Session["userCart"]);
                gvTransaction.DataSource = tempCart;
                gvTransaction.DataBind();
                for (int i = 0; i < tempCart.Count; i++)
                {
                    Product products = productRepository.getProduct(tempCart[i].productID);
                    total += (products.productPrice * tempCart[i].Quantity);
                }
                input_totalPrice.Text = total.ToString();
            }
        }

        protected void gvTransactionDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productID = int.Parse(gvTransaction.Rows[e.RowIndex].Cells[4].Text);
            if (Session["userCart"] != null)
            {
                List<TransactionDetail> tempCart = ((List<TransactionDetail>)Session["userCart"]);
                for(int i=0;i< tempCart.Count;i++)
                {
                    if (tempCart[i].productID == productID)
                    {
                        tempCart.RemoveAt(i);
                        break;
                    }
                }
                Session["userCart"] = tempCart;
            }
            
            Response.Redirect("Cart.aspx");
        }
        protected void button_buy_Click(object sender, EventArgs e)
        {
            if (Session["userCart"] != null)
            {
                int userID = userRepository.getUserID(Session["userSession"].ToString());
                transactionRepository.createTransaction(userID);
                /* create trasaction */
                int transactionID = db.Transactions.Where(x => x.userID == userID).Select(x => x.transactionID).FirstOrDefault();

                List<TransactionDetail> tempCart = ((List<TransactionDetail>)Session["userCart"]);
                List<Products> tempProduct = new List<Products>();
                for (int i = 0; i < tempCart.Count; i++)
                {
                    productRepository.decreaseProductStock(tempCart[i].productID, tempCart[i].Quantity);
                    /* createTransactionDetail */ 
                    transactionDetailRepository.createTransactionDetail(tempCart[i].Quantity, transactionID, tempCart[i].productID);
                }

                Session["userCart"] = null;
            }
            Response.Redirect("Cart.aspx");
        }

        protected void button_cancel_Click(object sender, EventArgs e)
        {
            if (Session["userCart"] != null)
            {
                Session["userCart"] = null;
                Response.Redirect("Cart.aspx");
            }
        }
    }
}