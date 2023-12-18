using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }

        public string Category_Name { get; set; }

        public string Category_Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
