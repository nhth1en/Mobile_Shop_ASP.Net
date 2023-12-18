using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Product> PreferredProducts { get; set; }

        public IEnumerable<Product> ProductsBestSelling { get; set; }

        public int ProductCount { get; set; }

        public IEnumerable<Banner> Banners { get; set; }
    }
}
