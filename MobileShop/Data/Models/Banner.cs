using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class Banner
    {
        [Key]
        public int Banner_Id { get; set; }
        public string Banner_Image { get; set; }
    }
}
