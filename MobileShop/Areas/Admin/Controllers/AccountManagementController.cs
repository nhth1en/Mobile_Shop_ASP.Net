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
    [Route("Admin/AccountManagement")]
    public class AccountManagementController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public AccountManagementController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                return View(_accountRepository.Accounts);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("ChangePassword/{id}")]
        [HttpGet]
        public IActionResult ChangePassword(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                Account account = _accountRepository.GetAccountById(id);
                if (account != null)
                {
                    return View(account);
                }
                return RedirectToAction("Index"); ///////////////// ERROR PAGE
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [Route("ChangePassword/{id}")]
        [HttpPost]
        public IActionResult ChangePassword(Account account, int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                Account acc = _accountRepository.GetAccountById(id);
                _accountRepository.ChangePassword(account, id);
                TempData["ChangePasswordSuccess"] = "Đổi mật khẩu tài khoản " + acc.Account_Email + " thành công.";
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Block/{id}")]
        [HttpPost]
        public IActionResult Block(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                Account acc = _accountRepository.GetAccountById(id);
                if (acc.Account_Id.ToString() == HttpContext.Session.GetString("UserID"))
                {
                    TempData["CantBlock"] = "Không thể khóa tài khoản của chính bạn.";
                    return RedirectToAction("Index");
                }
                else
                {
                    _accountRepository.Block(id);
                    TempData["BlockSuccess"] = "Khóa tài khoản " + acc.Account_Email + " thành công.";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Unblock/{id}")]
        [HttpPost]
        public IActionResult Unblock(int id)
        {
            Account acc = _accountRepository.GetAccountById(id);
            if (HttpContext.Session.GetString("UserID") != null)
            {
                _accountRepository.Unblock(id);
                TempData["UnblockSuccess"] = "Mở tài khoản " + acc.Account_Email + " thành công.";
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}