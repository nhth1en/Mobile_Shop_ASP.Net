using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.ViewModels;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/CategoryManagement")]
    public class CategoryManagementController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public CategoryManagementController(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");

                var query = _productRepository.Products
                .GroupBy(item => item.Category_Id)
                .Select(n => n.Count());

                ViewBag.query = query;

               
                return View(_categoryRepository.Categories);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Add")]
        [HttpGet]
        public IActionResult Add()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                if (ModelState.IsValid)
                {
                    _categoryRepository.Add(category);
                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                Category category = _categoryRepository.GetCategoryById(id);
                if (category != null)
                {
                    return View(category);
                }
                return RedirectToAction("Index"); ///////////////// ERROR PAGE
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Edit/{id}")]
        [HttpPost]
        public IActionResult Edit(Category category, int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                if (ModelState.IsValid)
                {
                    _categoryRepository.Edit(category, id);
                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Delete/{id}")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            ViewBag.FullName = HttpContext.Session.GetString("FullName");
            if (HttpContext.Session.GetString("UserID") != null)
            {
                try
                {
                    _categoryRepository.Delete(id);
                }
                catch
                {
                    TempData["CantDelele"] = "Không thể xóa loại sản phẩm này vì còn sản phẩm trong loại.";
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}