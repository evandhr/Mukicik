using Mukicik_backend.Factory;
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
        protected static Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            bindGv();
            product_placeholder.Visible = false;
            if (Session["userSession"] != null)
                if (userRepository.userRoleIdentifier(Session["userSession"].ToString()) > 0) product_placeholder.Visible = true;
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
            int listedQuantity = int.Parse(gvProducts.SelectedRow.Cells[6].Text);
            int selectedQuantity = int.Parse(input_productQuantity.Text);
            int selectedProductID = int.Parse(gvProducts.SelectedRow.Cells[1].Text);

            if (listedQuantity >= selectedQuantity)
            {
                if (addToCart(selectedProductID, selectedQuantity))
                {
                    Response.Redirect("Products.aspx");
                }
            }
        }
        protected Boolean addToCart(int productID, int productQuantity)
        {
            if (Session["userSession"] == null) return false;

            if (Session["userCart"] != null)
            {
                List<TransactionDetail> cartItems = ((List<TransactionDetail>)Session["userCart"]);
                bool sameProductID = false;
                for (int i = 0; i < cartItems.Count; i++)
                {
                    if (cartItems[i].productID == productID)
                    {
                        if (!productRepository.getProductAvail(productID, cartItems[i].Quantity + productQuantity)) return false;
                        cartItems[i].Quantity += productQuantity;
                        sameProductID = true;
                        productQuantity = cartItems[i].Quantity;
                        break;
                    }
                }
                if (!sameProductID) cartItems.Add(transactionDetailRepository.insertCart(productID, productQuantity));
                if (productRepository.getProductAvail(productID, productQuantity))
                {
                    Session["userCart"] = cartItems;
                    return true;
                }
                else return false;
            }

            if (Session["userCart"] == null)
            {
                List<TransactionDetail> cartItems = new List<TransactionDetail>();
                cartItems.Add(transactionDetailRepository.insertCart(productID, productQuantity));
                if (productRepository.getProductAvail(productID, productQuantity))
                {
                    Session.Add("userCart", cartItems);
                    return true;
                }
                else return false;
            } 
            return true;
        }
    }
}