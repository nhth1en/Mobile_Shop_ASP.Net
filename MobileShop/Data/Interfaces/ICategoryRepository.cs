using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }

        Category Add(Category category);

        Category Edit(Category category, int id);

        Category Delete(int id);

        Category GetCategoryById(int id);
    }
}
