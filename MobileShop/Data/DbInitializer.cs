using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Product_Name = "iPhone 11 Pro Max 512GB",
                        Product_Price = 43.990M,
                        Product_Description = "The most widely consumed alcohol",
                        Category = Categories["iPhone"],
                        Product_InStock = true,
                        Product_IsPreferred = true,
                        Product_ImageThumbnail = "https://cdn.tgdd.vn/Products/Images/42/210654/iphone-11-pro-max-512gb-gold-600x600.jpg"
                    });       
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { Category_Name = "iPhone", Category_Description="Điện thoại iPhone" },
                        new Category { Category_Name = "Samsung", Category_Description="Điện thoại Samsung" },
                        new Category { Category_Name = "OPPO", Category_Description="Điện thoại OPPO" },
                        new Category { Category_Name = "Xiaomi", Category_Description="Điện thoại Xiaomi" },
                        new Category { Category_Name = "Huawei", Category_Description="Điện thoại Huawei" },
                        new Category { Category_Name = "Realme", Category_Description="Điện thoại Realme" },
                        new Category { Category_Name = "Vsmart", Category_Description="Điện thoại Vsmart" },
                        new Category { Category_Name = "Nokia", Category_Description="Điện thoại Nokia" },
                        new Category { Category_Name = "Coolpad", Category_Description="Điện thoại Coolpad" },
                        new Category { Category_Name = "ASUS", Category_Description="Điện thoại ASUS" },
                        new Category { Category_Name = "BlackBerry", Category_Description="Điện thoại BlackBerry" },
                        new Category { Category_Name = "Mobiistar", Category_Description="Điện thoại Mobiistar" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.Category_Name, genre);
                    }
                }

                return categories;
            }
        }
    }
}
