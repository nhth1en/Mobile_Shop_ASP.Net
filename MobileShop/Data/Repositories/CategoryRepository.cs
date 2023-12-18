using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Categories => _appDbContext.Categories;

        public Category Add(Category category)
        {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
            return category;
        }

        public Category Delete(int id)
        {
            Category c = _appDbContext.Categories.Find(id);
            if (c != null)
            {
                _appDbContext.Categories.Remove(c);
                _appDbContext.SaveChanges();
            }
            return c;
        }

        public Category Edit(Category category, int id)
        {
            Category c = _appDbContext.Categories.Find(id);
            if (c != null)
            {
                c.Category_Name = category.Category_Name;
                c.Category_Description = category.Category_Description;
                _appDbContext.SaveChanges();
            }
            return c;
        }

        public Category GetCategoryById(int id)
        {
            return _appDbContext.Categories.Find(id);
        }
    }
}
