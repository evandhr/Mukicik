using Mukicik_backend.Model;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            bindGv();
            bindCg();
        }

        protected void bindCg()
        {
            ddl_category.DataSource = Mukicik_backend.Repository.categoryRepository.listCategories();
            ddl_category.DataTextField = "categoryName";
            ddl_category.DataValueField = "categoryID";
            ddl_category.DataBind();
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

        protected void button_edit_Click(object sender, EventArgs e)
        {
            
        }

        protected void button_remove_Click(object sender, EventArgs e)
        {

        }

        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_productID.Text = gvProducts.SelectedRow.Cells[1].Text;
        }
    }
}