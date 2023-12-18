using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }

        public List<OrderDetail> OrderLines { get; set; }

        public string Order_Name { get; set; }

        public string Order_Address { get; set; }

        public string Order_PhoneNumber { get; set; }

        public string Order_Email { get; set; }

        public decimal Order_Total { get; set; }

        public DateTime Order_Placed { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
