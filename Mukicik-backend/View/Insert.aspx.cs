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
    public partial class Insert : System.Web.UI.Page
    {
        protected static Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userSession"] != null)
            {
                if (userRepository.userRoleIdentifier(Session["userSession"].ToString()) == 10)
                {
                    label_errorLabel.Visible = false;
                    placeholder_insertProduct.Visible = true;
                    ddl_category.DataSource = categoryRepository.listCategories();
                    ddl_category.DataTextField = "categoryName";
                    ddl_category.DataValueField = "categoryID";
                    ddl_category.DataBind();
                }
                else placeholder_insertProduct.Visible = false;
            }
        }
        protected void button_insertProduct_Click(object sender, EventArgs e)
        {
            string productName = input_productName.Text,
                    productImage = input_productImage.Text;

            int productPrice = int.Parse(input_productPrice.Text),
                    productStock = int.Parse(input_productStock.Text),
                    categoryID = int.Parse(ddl_category.SelectedValue);

            float productRating = float.Parse(input_productRating.Text);

            string temp_product = (from x in db.Products where x.productName == productName select x.productName).ToString();
            if(temp_product != productName)
            {
                productRepository.createProduct(productName, productPrice, productImage, productRating, productStock, categoryID);
            }
        }
    }
}