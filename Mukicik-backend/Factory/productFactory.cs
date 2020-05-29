using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Factory
{
    public class productFactory
    {
        public static Product generateProduct(string productName, int productPrice, string productImage, float productRating, int productStock, int categoryID)
        {
            Product np = new Product();
            np.productName = productName;
            np.productPrice = productPrice;
            np.productImage = productImage;
            np.productRating = productRating;
            np.productStock = productStock;
            np.categoryID = categoryID;
            return np;
        }
        public static Product updateProduct(int productID, string productName, int productPrice, string productImage, float productRating, int productStock, int categoryID)
        {
            Product np = new Product();
            np.productID = productID;
            np.productName = productName;
            np.productPrice = productPrice;
            np.productImage = productImage;
            np.productRating = productRating;
            np.productStock = productStock;
            np.categoryID = categoryID;
            return np;
        }
    }
}