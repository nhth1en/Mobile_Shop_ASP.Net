using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.Data.ViewModels;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/BannerManagement")]
    public class BannerManagementController : Controller
    {
        private readonly IBannerRepository _bannerRepository;

        public BannerManagementController(IBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");


                ViewBag.Banners = _bannerRepository.Banners;

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Banner banner, IFormFile Banner_Image)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                string extention = Path.GetExtension(Banner_Image.FileName);
                if (extention != ".jpg" && extention != ".png")
                {
                    TempData["NotImage"] = "Tệp tải lên phải là ảnh .jpg hoặc .png.";
                    return RedirectToAction("Index");
                }
                _bannerRepository.Add(banner, Banner_Image);
                return RedirectToAction("Index");
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
                _bannerRepository.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}