using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.ViewModels
{
    public class OrderListViewModel
    {
        public Order Order { get; set; }

        public IEnumerable<OrderDetail> OrderDetail { get; set; }

        public List<Product> Products { get; set; }
    }
}
