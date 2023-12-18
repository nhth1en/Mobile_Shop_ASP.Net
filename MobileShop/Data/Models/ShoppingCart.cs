using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public string ShoppingCart_Id { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCart_Id = cartId };
        }
        public void AddToCart(Product product, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Product.Product_Id == product.Product_Id && s.ShoppingCart_Id == ShoppingCart_Id);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCart_Id = ShoppingCart_Id,
                    Product = product,
                    ShoppingCartItem_Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.ShoppingCartItem_Amount++;
            }
            _appDbContext.SaveChanges();
        }
        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Product.Product_Id == product.Product_Id && s.ShoppingCart_Id == ShoppingCart_Id);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.ShoppingCartItem_Amount > 1)
                {
                    shoppingCartItem.ShoppingCartItem_Amount--;
                    localAmount = shoppingCartItem.ShoppingCartItem_Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public void RemoveProductFromCart(Product product)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Product.Product_Id == product.Product_Id && s.ShoppingCart_Id == ShoppingCart_Id);
            if (shoppingCartItem != null)
            {
                _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
            }
            _appDbContext.SaveChanges();
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCart_Id == ShoppingCart_Id).Include(s => s.Product).ToList());
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(cart => cart.ShoppingCart_Id == ShoppingCart_Id);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCart_Id == ShoppingCart_Id).Select(c => c.Product.Product_Price * c.ShoppingCartItem_Amount).Sum();
            return total;
        }
    }
}
