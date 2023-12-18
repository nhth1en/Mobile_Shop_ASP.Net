using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetail_Id { get; set; }
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public int OrderDetail_Amount { get; set; }
        public decimal OrderDetail_Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
