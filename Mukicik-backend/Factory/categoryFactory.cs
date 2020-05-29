using Mukicik_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik_backend.Factory
{
    public class categoryFactory
    {
        public static Category generateCategory(string categoryName)
        {
            Category gc = new Category();
            gc.categoryName = categoryName;
            return gc;
        }
    }
}