using Mukicik_backend.Factory;
using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Repository
{
    public class categoryRepository
    {
        public static void createCategory(string categoryName)
        {
            Category nc = categoryFactory.generateCategory(categoryName);
            Database1Entities db = new Database1Entities();

            db.Categories.Add(nc);
            db.SaveChanges();
        }

        public static List<Category> findCategoryByName(string categoryName)
        {
            using (Database1Entities db = new Database1Entities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Categories.Where(x => x.categoryName == categoryName).Select(x => x).ToList();
            }
        }

        public static List<Category> listCategories()
        {
            using (Database1Entities db = new Database1Entities())
            {
                List<Category> lc = (from x in db.Categories select x).ToList();
                return lc;
            }
        }
    }
}