using System.Collections.Generic;
using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Repositories
{
    public class CategoryRepository : ICategories
    {
        private readonly CategoryContext _context;

        public CategoryRepository(CategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> AllCategories => _context.Categories;
        public IEnumerable<Category> GetCategoriesByType(long typeId) => _context.Categories.Where(f => f.TypeId == typeId);
        public IEnumerable<Category> GetCategoriesByType(Type type) => _context.Categories.Where(f => f.Type == type);

        public Category GetCategoryById(long categoryId) => _context.Categories.FirstOrDefault(f => f.Id == categoryId);
    }
}