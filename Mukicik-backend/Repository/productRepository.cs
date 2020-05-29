using Mukicik_backend.Factory;
using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Repository
{
    public class productRepository
    {
        public static void createProduct(string productName, int productPrice, string productImage, float productRating, int productStock, int categoryID) 
        {
            using (Database1Entities db = new Database1Entities())
            {
                Product np = productFactory.generateProduct(productName, productPrice, productImage, productRating, productStock, categoryID);
                db.Products.Add(np);
                db.SaveChanges();
            }
        }
        public static void editProduct(int productID, string productName, int productPrice, string productImage, float productRating, int productStock, int categoryID)
        {
            Database1Entities db = new Database1Entities();
            Product updateProduct = productFactory.updateProduct(productID, productName, productPrice, productImage, productRating, productStock, categoryID);
            Product getProduct = (from x in db.Products where x.productID == updateProduct.productID select x).SingleOrDefault();

            getProduct.productName = updateProduct.productName;
            getProduct.productPrice = updateProduct.productPrice;
            getProduct.productStock = updateProduct.productStock;
            getProduct.productImage = updateProduct.productImage;
            getProduct.productRating = updateProduct.productRating;
            getProduct.categoryID = updateProduct.categoryID;
            db.SaveChanges();
        }
        public static void deleteProduct(int ID)
        {
            using (Database1Entities db = new Database1Entities())
            {
                Product getProduct = (from x in db.Products where x.productID == ID select x).SingleOrDefault();

                db.Products.Remove(getProduct);
                db.SaveChanges();
            }
        }

        public static Product getProduct(int productID)
        {
            using (Database1Entities db = new Database1Entities()) 
            {
                var temp = (from x in db.Products where x.productID == productID select x).ToList();
                return temp[0];
            }
        }
    }
}