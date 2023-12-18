using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.ViewModels;

namespace MobileShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Detail(int id)
        {
            ViewBag.Product = _productRepository.GetProductById(id);

            return View(_productRepository.OtherProducts());
        }
        public IActionResult AllProducts()
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.Products;
            vm.Categories = _categoryRepository.Categories;
            return View(vm);
        }
        public IActionResult BestSellingProducts()
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.ProductsBestSelling("All");
            vm.Categories = _categoryRepository.Categories;
            return View(vm);
        }
        public IActionResult PreferredProducts()
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.PreferredProducts("All");
            vm.Categories = _categoryRepository.Categories;
            return View(vm);
        }
        
    }
}