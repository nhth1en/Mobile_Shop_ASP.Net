using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }

        public string Order_Name { get; set; }

        public string Order_Address { get; set; }

        public string Order_PhoneNumber { get; set; }

        public string Order_Email { get; set; }
    }
}
