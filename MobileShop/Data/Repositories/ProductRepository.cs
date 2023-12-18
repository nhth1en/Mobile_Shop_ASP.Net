using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> Products => _appDbContext.Products;

        public IEnumerable<Product> PreferredProducts(string Get = "")
        {
            if (Get == "All")
            {
                return _appDbContext.Products.Where(p => p.Product_IsPreferred == true).Select(p => p);
            }
            return _appDbContext.Products.Where(p => p.Product_IsPreferred == true).Select(p => p).Take(5);
        }

        public IEnumerable<Product> ProductsBestSelling(string Get = "")
        {
            if (Get == "All")
            {
                return _appDbContext.Products.OrderByDescending(p => p.Product_Purchased);
            }
            return _appDbContext.Products.OrderByDescending(p => p.Product_Purchased).Take(5);
        }

        public IEnumerable<Product> OtherProducts()
        {
            return _appDbContext.Products.OrderBy(x => Guid.NewGuid()).Take(5);
        }
        
        public Product GetProductById(int id)
        {
            return _appDbContext.Products.Find(id);
        }
        public IEnumerable<Product> GetAllProducts() => _appDbContext.Products;

        public IEnumerable<Product> GetAllProductsByCategoryId(int id)
        {
            return _appDbContext.Products.Where(p => p.Category_Id == id).Select(p => p);
        }

        public IEnumerable<Product> Search(string keyword)
        {
            return _appDbContext.Products.Where(p => p.Product_Name.Contains(keyword)).Select(p => p);
        }

        public IEnumerable<Product> OrderByPriceASC(string keyword = "", int id = 0)
        {
            if (id != 0)
            {
                return _appDbContext.Products.Where(p => p.Category_Id == id).OrderBy(p => p.Product_Price);
            }
            return _appDbContext.Products.Where(p => p.Product_Name.Contains(keyword)).OrderBy(p => p.Product_Price);
        }

        public IEnumerable<Product> OrderByPriceDESC(string keyword = "", int id = 0)
        {
            if (id != 0)
            {
                return _appDbContext.Products.Where(p => p.Category_Id == id).OrderByDescending(p => p.Product_Price);
            }
            return _appDbContext.Products.Where(p => p.Product_Name.Contains(keyword)).OrderByDescending(p => p.Product_Price);
        }

        public IEnumerable<Product> OrderByPriceOption(decimal val1, decimal val2, string keyword = "", int id = 0)
        {
            if (id != 0)
            {
                if (val2 == 0)
                {
                    return _appDbContext.Products.Where(p => p.Category_Id == id && p.Product_Price > val1).Select(p => p);
                }
                else
                {
                    return _appDbContext.Products.Where(p => p.Category_Id == id && p.Product_Price > val1 && p.Product_Price <= val2).Select(p => p);
                }
            }
            else
            {
                if (val2 == 0)
                {
                    return _appDbContext.Products.Where(p => p.Product_Name.Contains(keyword) && p.Product_Price > val1).Select(p => p);
                }
                else
                {
                    return _appDbContext.Products.Where(p => p.Product_Name.Contains(keyword) && p.Product_Price > val1 && p.Product_Price <= val2).Select(p => p);
                }
            }
        }

        public int TotalProductsSold()
        {
            return _appDbContext.Products.Select(p => p.Product_Purchased).Sum();
        }

        public Product Add(Product product, IFormFile photo)
        {
            AddPhoto(product, photo);

            _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
            return product;
        }

        public Product Edit(Product product, int id, IFormFile photo)
        {
            Product p = _appDbContext.Products.Find(id);
            if (p != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", p.Product_ImageThumbnail);

                p.Product_Name = product.Product_Name;
                p.Product_Price = product.Product_Price;
                p.Product_Description = product.Product_Description;
                p.Product_InStock = product.Product_InStock;
                p.Product_IsPreferred = product.Product_IsPreferred;

                if (photo != null)
                {
                    AddPhoto(product, photo);
                    p.Product_ImageThumbnail = product.Product_ImageThumbnail;
                }
                
                p.Product_OperatingSystem = product.Product_OperatingSystem;
                p.Product_Chipset = product.Product_Chipset;
                p.Product_CPUSpeed = product.Product_CPUSpeed;
                p.Product_GPU = product.Product_GPU;
                p.Product_ScreenResolution = product.Product_ScreenResolution;
                p.Product_ScreenWidth = product.Product_ScreenWidth;
                p.Product_RAM = product.Product_RAM;
                p.Product_ROM = product.Product_ROM;
                p.Product_SDCardSupport = product.Product_SDCardSupport;
                p.Product_SDCard = product.Product_SDCard;
                p.Product_FrontCamera = product.Product_FrontCamera;
                p.Product_RearCamera = product.Product_RearCamera;
                p.Category_Id = product.Category_Id;
               

                _appDbContext.SaveChanges();

                if (File.Exists(path) && photo != null)
                {
                    File.Delete(path);
                }
            }
            return p;
        }

        public Product Delete(int id)
        {
            OrderDetail o = _appDbContext.OrderDetails.Where(x => x.Product_Id == id).FirstOrDefault();
            if (o != null)
            {
                return null;
            }
            Product p = _appDbContext.Products.Find(id);
            if (p != null)
            {
                _appDbContext.Products.Remove(p);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", p.Product_ImageThumbnail);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                _appDbContext.SaveChanges();
            }
            return p;
        }

        public void AddPhoto(Product product, IFormFile photo)
        {
            Random rand = new Random();
            string random = DateTime.Now.ToString("dd-MM-yyyy-HHmmss") + rand.Next(1, 1000);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", random + photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(stream).Wait();
            product.Product_ImageThumbnail = random + photo.FileName;
            stream.Close();
        }
    }
}