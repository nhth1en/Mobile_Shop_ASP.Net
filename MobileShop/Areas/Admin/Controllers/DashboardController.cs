using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Dashboard")]
    public class DashboardController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
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
    }
}