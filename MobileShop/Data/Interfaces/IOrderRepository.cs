using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }

        Order GetOrderById(int id);
        IEnumerable<OrderDetail> GetOrderDetailByOrderID(int id);

        Order Complete(int id);
        Order InComplete(int id);

        void CreateOrder(Order order);

        int TotalOrderIncomplete();
    }
}
