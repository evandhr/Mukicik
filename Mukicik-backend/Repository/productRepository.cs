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
        protected static Database1Entities db = new Database1Entities();
        public static void createProduct(string productName, int productPrice, string productImage, float productRating, int productStock, int categoryID) 
        {
            Product np = productFactory.generateProduct(productName, productPrice, productImage, productRating, productStock, categoryID);
            db.Products.Add(np);
            db.SaveChanges();
        }
        public static void editProduct(int productID, string productName, int productPrice, string productImage, float productRating, int productStock, int categoryID)
        {
            using (Database1Entities dbe = new Database1Entities())
            {
                Product cp = (from x in dbe.Products where x.productID == productID select x).SingleOrDefault();
                cp.productID = productID;
                cp.productName = productName;
                cp.productPrice = productPrice;
                cp.productImage = productImage;
                cp.productRating = productRating;
                cp.productStock = productStock;
                cp.categoryID = categoryID;
                dbe.SaveChanges();
            }
        }
        public static void decreaseProductStock(int productID, int newStock)
        {
            Product p = (from x in db.Products where x.productID == productID select x).SingleOrDefault();
            if (p.productStock >= newStock)
            {
                p.productStock = p.productStock - newStock;
                db.SaveChanges();
            }
        }
        public static void deleteProduct(int ID)
        {
            Product getProduct = (from x in db.Products where x.productID == ID select x).SingleOrDefault();

            db.Products.Remove(getProduct);
            db.SaveChanges();
        }

        public static Product getProduct(int productID)
        {
            var temp = (from x in db.Products where x.productID == productID select x).ToList();
            return temp[0];
        }
        public static Boolean getProductAvail(int productID, int Quantity)
        {
            var data = (from x in db.Products where x.productID == productID select x.productStock).ToList();
            int currQuantity = data[0];
            if (currQuantity >= Quantity) return true;
            else return false;
        }
    }
}