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
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindGv();
        }

        protected void bindGv()
        {
            using (Database1Entities db = new Database1Entities())
            {
                List<Product> products = db.Products.ToList();
                gvProducts.DataSource = products;
                gvProducts.DataBind();
            }
        }

        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_productName.Text = gvProducts.SelectedRow.Cells[2].Text;
            input_productPrice.Text = gvProducts.SelectedRow.Cells[3].Text;
        }

        protected void button_addToCart_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(input_productQuantity.Text);

            if (qty > int.Parse(gvProducts.SelectedRow.Cells[6].Text))
            {
                label_error.Text = "Invalid Stock";
            } else
            {
                Database1Entities db = new Database1Entities();
                /* Transaction */
                User selectedUser = userRepository.getUserID(Session["userSession"].ToString());
                DateTime transactionDate = DateTime.Now;
                transactionRepository.createTransaction(transactionDate, Convert.ToInt32(selectedUser));
                
                /* TransactionDetail */
                int itemQuantity = Convert.ToInt32(input_productQuantity.Text);
                int transactionID = Convert.ToInt32(transactionRepository.getTransactionID(Convert.ToInt32(selectedUser)));
                int productID = Convert.ToInt32(gvProducts.SelectedRow.Cells[1].Text);
                transactionDetailRepository.createTransactionDetail(itemQuantity, transactionID, productID);
            }
        }
    }
}