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
    public partial class Edit : System.Web.UI.Page
    {
        protected static Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userSession"] != null)
            {
                if (userRepository.userRoleIdentifier(Session["userSession"].ToString()) == 10)
                {
                    placeholder_edit.Visible = true;
                    dataBinding();
                }
                else placeholder_edit.Visible = false;
            }
        }

        protected void dataBinding()
        {
            if (!IsPostBack)
            {
                List<Product> products = db.Products.ToList();
                ddl_category.DataSource = categoryRepository.listCategories();

                gvEdit.DataSource = products;
                gvEdit.DataBind();

                ddl_category.DataTextField = "categoryName";
                ddl_category.DataValueField = "categoryID";
                ddl_category.DataBind();
            }
        }

        protected void bindCg()
        {

        }

        protected void button_edit_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(gvEdit.SelectedRow.Cells[1].Text),
             productPrice = int.Parse(input_productPrice.Text),
             productStock = int.Parse(input_productStock.Text),
             productCategory = int.Parse(ddl_category.SelectedValue);
            string productName = input_productName.Text,
             productImage = input_productImage.Text;
            float productRating = float.Parse(input_productRating.Text);

            productRepository.editProduct(productID, productName, productPrice, productImage, productRating, productStock, productCategory);
            Response.Redirect("Edit.aspx");
        }

        protected void button_remove_Click(object sender, EventArgs e)
        {
            productRepository.deleteProduct(int.Parse(gvEdit.SelectedRow.Cells[1].Text));
            Response.Redirect("Edit.aspx");
        }

        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_productID.Text = gvEdit.SelectedRow.Cells[1].Text;
            input_productName.Text = gvEdit.SelectedRow.Cells[2].Text;
            input_productPrice.Text = gvEdit.SelectedRow.Cells[3].Text;
            input_productImage.Text = gvEdit.SelectedRow.Cells[4].Text;
            input_productRating.Text = gvEdit.SelectedRow.Cells[5].Text;
            input_productStock.Text = gvEdit.SelectedRow.Cells[6].Text;

            ddl_category.SelectedValue = gvEdit.SelectedRow.Cells[7].Text;
        }
    }
}