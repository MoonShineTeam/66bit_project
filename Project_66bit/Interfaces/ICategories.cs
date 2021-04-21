using System.Collections.Generic;
using Project_66bit.Models;

namespace Project_66bit.Interfaces
{
    public interface ICategories
    {
        IEnumerable<Category> AllCategories { get; }
        IEnumerable<Category> GetCategoriesByType(int typeId);
        Category GetCategoryById(int categoryId);
    }
}