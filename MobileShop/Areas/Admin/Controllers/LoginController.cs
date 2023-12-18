using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Login")]
    public class LoginController : Controller
    {
        private readonly IAccountRepository _accountRepository;
       
        public LoginController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;          
        }
        [Route("")]
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }
        }
        [Route("")]
        [Route("Index")]
        [HttpPost]
        public IActionResult Index(Account account)
        {
            var acc = _accountRepository.Login(account);
            if (acc != null)
            {
                if (acc.Account_Permission == "Admin")
                {
                    if (acc.Account_IsBlocked == true)
                    {
                        ViewBag.Error = "Tài khoản của bạn đã bị khóa.";
                        return View();
                    }
                    HttpContext.Session.SetString("UserID", acc.Account_Id.ToString());
                    HttpContext.Session.SetString("FullName", acc.Account_FullName.ToString());
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ViewBag.Error = "Bạn không có quyền truy cập.";
                }
            }
            else
            {
                ViewBag.Error = "Tên tài khoản hoặc mật khẩu không đúng.";
            }
            return View();
        }
        [Route("Logout")]
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}