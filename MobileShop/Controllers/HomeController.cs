using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.ViewModels;

namespace MobileShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBannerRepository _bannerRepository;

        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository, IBannerRepository bannerRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _bannerRepository = bannerRepository;
        }
        public IActionResult Index()
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.PreferredProducts = _productRepository.PreferredProducts();
            vm.Products = _productRepository.Products.Take(10);
            vm.Categories = _categoryRepository.Categories;
            vm.ProductsBestSelling = _productRepository.ProductsBestSelling();

            vm.Banners = _bannerRepository.Banners;

            return View(vm);
        }
    }
}