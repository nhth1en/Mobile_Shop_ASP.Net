using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MobileShop.Data.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }

        public string Product_Name { get; set; }

        public decimal Product_Price { get; set; }

        public string Product_Description { get; set; }

        public bool Product_InStock { get; set; }

        public bool Product_IsPreferred { get; set; }

        public string Product_ImageThumbnail { get; set; }

        public string Product_OperatingSystem { get; set; }

        public string Product_Chipset { get; set; }

        public string Product_CPUSpeed { get; set; }

        public string Product_GPU { get; set; }

        public string Product_ScreenResolution { get; set; }

        public string Product_ScreenWidth { get; set; }

        public string Product_RAM { get; set; }

        public string Product_ROM { get; set; }

        public bool Product_SDCardSupport { get; set; }

        public string Product_SDCard { get; set; }

        public string Product_FrontCamera { get; set; }

        public string Product_RearCamera { get; set; }

        public int Category_Id { get; set; }

        public int Product_Purchased { get; set; }

        public virtual Category Category { get; set; } 
    }
}
