using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public IEnumerable<Order> Orders => _appDbContext.Orders;

        public Order GetOrderById(int id)
        {
            return _appDbContext.Orders.Find(id);
        }

        public IEnumerable<OrderDetail> GetOrderDetailByOrderID(int id)
        {
            return _appDbContext.OrderDetails.Where(x => x.Order_Id == id).Select(x => x);
        }

        public Order Complete(int id)
        {
            Order o = _appDbContext.Orders.Find(id);
            if (o != null)
            {
                o.IsCompleted = true;
                _appDbContext.SaveChanges();
            }
            return o;
        }

        public Order InComplete(int id)
        {
            Order o = _appDbContext.Orders.Find(id);
            if (o != null)
            {
                o.IsCompleted = false;
                _appDbContext.SaveChanges();
            }
            return o;
        }

        public void CreateOrder(Order order)
        {
            order.Order_Placed = DateTime.Now;

            order.Order_Total = _shoppingCart.GetShoppingCartTotal();

            order.IsCompleted = false;

            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderDetail_Amount = shoppingCartItem.ShoppingCartItem_Amount,
                    Product_Id = shoppingCartItem.Product.Product_Id,
                    Order_Id = order.Order_Id,
                    OrderDetail_Price = shoppingCartItem.Product.Product_Price
                };

                _appDbContext.OrderDetails.Add(orderDetail);

                Product p = _appDbContext.Products.Find(shoppingCartItem.Product.Product_Id);
                if (p != null)
                {
                    p.Product_Purchased += shoppingCartItem.ShoppingCartItem_Amount;                  
                }
            }

            _appDbContext.SaveChanges();
        }

        public int TotalOrderIncomplete()
        {
            return _appDbContext.Orders.Where(o => o.IsCompleted == false).Count();
        }
    }
}
