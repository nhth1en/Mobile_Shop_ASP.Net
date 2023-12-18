using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.ViewModels;

namespace MobileShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public IActionResult AddToShoppingCart(int id)
        {
            var selectedProduct = _productRepository.Products.FirstOrDefault(p => p.Product_Id == id);
            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int id)
        {
            var selectedProduct = _productRepository.Products.FirstOrDefault(p => p.Product_Id == id);
            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveProductFromShoppingCart(int id)
        {
            var selectedProduct = _productRepository.Products.FirstOrDefault(p => p.Product_Id == id);
            if (selectedProduct != null)
            {
                _shoppingCart.RemoveProductFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }

        public IActionResult ClearShoppingCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}