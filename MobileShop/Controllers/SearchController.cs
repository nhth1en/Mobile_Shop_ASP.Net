using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;

namespace MobileShop.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProductRepository _productRepository;

        public SearchController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public IActionResult Index(string keyword)
        {
            HttpContext.Session.SetString("KEYWORD", keyword);

            ViewBag.keyword = keyword;
            ViewBag.result = _productRepository.Search(keyword).Count();
            return View(_productRepository.Search(keyword));
        }

        public IActionResult OrderByPriceASC()
        {
            ViewBag.keyword = HttpContext.Session.GetString("KEYWORD");
            ViewBag.result = _productRepository.OrderByPriceASC(HttpContext.Session.GetString("KEYWORD")).Count();
            ViewBag.changecssASC = "border: none; background-color: #fff365;";

            return View("Index", _productRepository.OrderByPriceASC(HttpContext.Session.GetString("KEYWORD")));
        }

        public IActionResult OrderByPriceDESC()
        {
            ViewBag.keyword = HttpContext.Session.GetString("KEYWORD");
            ViewBag.result = _productRepository.OrderByPriceDESC(HttpContext.Session.GetString("KEYWORD")).Count();
            ViewBag.changecssDESC = "border: none; background-color: #fff365;";

            return View("Index", _productRepository.OrderByPriceDESC(HttpContext.Session.GetString("KEYWORD")));
        }

        public IActionResult OrderByPriceOption(decimal val1, decimal val2)
        {
            ViewBag.keyword = HttpContext.Session.GetString("KEYWORD");
            ViewBag.result = _productRepository.OrderByPriceOption(val1, val2, HttpContext.Session.GetString("KEYWORD")).Count();

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

            return View("Index", _productRepository.OrderByPriceOption(val1, val2, HttpContext.Session.GetString("KEYWORD")));
        }
    }
}