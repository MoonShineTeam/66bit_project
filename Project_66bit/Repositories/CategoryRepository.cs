using System.Collections.Generic;
using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Repositories
{
    public class CategoryRepository : ICategories
    {
        private readonly CategoryContext _db;

        public CategoryRepository(CategoryContext db)
        {
            _db = db;
        }

        public IEnumerable<Category> AllCategories => _db.Categories;
        public IEnumerable<Category> GetCategoriesByType(int typeId) => _db.Categories.Where(f => f.Id == typeId);
    }
}