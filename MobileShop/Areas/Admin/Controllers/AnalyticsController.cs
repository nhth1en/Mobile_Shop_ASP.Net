using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.ViewModels;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Analytics")]
    public class AnalyticsController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IOrderRepository _orderRepository;

        public AnalyticsController(IProductRepository productRepository, ICategoryRepository categoryRepository, IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _orderRepository = orderRepository;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");

                AnalyticsViewModel vm = new AnalyticsViewModel();
                vm.TotalProducts = _productRepository.Products.Count();
                vm.TotalCategories = _categoryRepository.Categories.Count();
                vm.TotalProductsSold = _productRepository.TotalProductsSold();
                vm.TotalOrderIncomplete = _orderRepository.TotalOrderIncomplete();
                return View(vm);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}