using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.ViewModels
{
    public class AnalyticsViewModel
    {
        public int TotalProducts { get; set; }
        public int TotalCategories { get; set; }
        public int TotalProductsSold { get; set; }
        public int TotalOrderIncomplete { get; set; }

    }
}
