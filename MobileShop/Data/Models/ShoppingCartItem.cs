using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItem_Id { get; set; }  

        public int ShoppingCartItem_Amount { get; set; }

        public virtual Product Product { get; set; }

        public string ShoppingCart_Id { get; set; } 
    }
}
