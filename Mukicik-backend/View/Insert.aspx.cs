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
        protected void Page_Load(object sender, EventArgs e)
        {
            label_errorLabel.Visible = false;
            ddl_category.DataSource = Mukicik_backend.Repository.categoryRepository.listCategories();
            ddl_category.DataTextField = "categoryName";
            ddl_category.DataValueField = "categoryID";
            ddl_category.DataBind();
        }

        protected void button_insertProduct_Click(object sender, EventArgs e)
        {
            string productName = input_productName.Text,
                    productImage = input_productImage.Text;

            int productPrice = int.Parse(input_productPrice.Text),
                    productStock = int.Parse(input_productStock.Text),
                    categoryID = int.Parse(ddl_category.SelectedValue);

            float productRating = float.Parse(input_productRating.Text);

            productRepository.createProduct(productName, productPrice, productImage, productRating, productStock, categoryID);
            
        }
    }
}