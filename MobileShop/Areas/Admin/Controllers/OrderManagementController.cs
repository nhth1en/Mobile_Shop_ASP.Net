using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.Data.ViewModels;
using PagedList.Core;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/OrderManagement")]
    public class OrderManagementController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderManagementController(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index(int page = 1)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                PagedList<Order> model = new PagedList<Order>(_orderRepository.Orders, page, 10);
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [Route("Complete/{id}")]
        [HttpPost]
        public IActionResult Complete(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                Order order = _orderRepository.GetOrderById(id);

                _orderRepository.Complete(id);
                TempData["CompleteSuccess"] = "Hoàn thành đơn hàng: Mã đơn hàng - " + order.Order_Id + " thành công.";
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [Route("InComplete/{id}")]
        [HttpPost]
        public IActionResult InComplete(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                Order order = _orderRepository.GetOrderById(id);

                _orderRepository.InComplete(id);
                TempData["InCompleteSuccess"] = "Hủy hoàn thành đơn hàng: Mã đơn hàng - " + order.Order_Id + " thành công.";
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [Route("Detail/{id}")]
        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                OrderListViewModel vm = new OrderListViewModel();
                vm.Order = _orderRepository.GetOrderById(id);
                vm.OrderDetail = _orderRepository.GetOrderDetailByOrderID(id);

                ViewBag.OrderDetailCount = _orderRepository.GetOrderDetailByOrderID(id).Count();

                List<Product> px = new List<Product>();
                
                foreach (var item in vm.OrderDetail)
                {
                    var x = _productRepository.Products.Where(p => p.Product_Id == item.Product_Id).FirstOrDefault();
                    px.Add(x);
                }

                vm.Products = px;
                
                return View(vm);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}