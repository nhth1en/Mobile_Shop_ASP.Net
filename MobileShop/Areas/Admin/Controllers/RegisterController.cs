using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Register")]
    public class RegisterController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public RegisterController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        [Route("")]
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        [Route("Index")]
        [HttpPost]
        public IActionResult Index(Account account)
        {
            if (_accountRepository.Register(account) != null)
            {
                ViewBag.RegisterSuccess = "Đăng ký tài khoản thành công.";
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Email đã được đăng ký.");
                return View();
            }
        }
    }
}