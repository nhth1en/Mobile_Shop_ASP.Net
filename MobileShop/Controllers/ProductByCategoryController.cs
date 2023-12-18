using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.ViewModels;

namespace MobileShop.Controllers
{
    public class ProductByCategoryController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductByCategoryController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index(int id)
        {
            HttpContext.Session.SetString("CategoryID", id.ToString());

            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.GetAllProductsByCategoryId(id);
            vm.Categories = _categoryRepository.Categories;
            return View(vm);
        }

        public IActionResult OrderByPriceASC()
        {
            ViewBag.changecssASC = "border: none; background-color: #fff365;";

            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.OrderByPriceASC("", Convert.ToInt32(HttpContext.Session.GetString("CategoryID")));
            vm.Categories = _categoryRepository.Categories;
            return View("Index", vm);
        }

        public IActionResult OrderByPriceDESC()
        {
            ViewBag.changecssDESC = "border: none; background-color: #fff365;";

            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.OrderByPriceDESC("", Convert.ToInt32(HttpContext.Session.GetString("CategoryID")));
            vm.Categories = _categoryRepository.Categories;
            return View("Index", vm);
        }

        public IActionResult OrderByPriceOption(decimal val1, decimal val2)
        {
            if (val1 == 0)
            {
                ViewBag.changecss1 = "border: none; background-color: #fff365;";
            }
            else if (val1 == 4000000)
            {
                ViewBag.changecss2 = "border: none; background-color: #fff365;";
            }
            else if (val1 == 7000000)
            {
                ViewBag.changecss3 = "border: none; background-color: #fff365;";
            }
            else if (val1 == 12000000)
            {
                ViewBag.changecss4 = "border: none; background-color: #fff365;";
            }

            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.OrderByPriceOption(val1, val2, "", Convert.ToInt32(HttpContext.Session.GetString("CategoryID")));
            vm.Categories = _categoryRepository.Categories;

            return View("Index", vm);
        }
    }
}