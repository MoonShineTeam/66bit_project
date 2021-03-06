using System.Collections.Generic;
using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Repositories
{
    public class TypeRepository : ITypes
    {
        private readonly CategoryContext _context;

        public TypeRepository(CategoryContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Type> AllTypes => _context.Types;

        public Type GetTypeById(long typeId) => _context.Types.FirstOrDefault(f => f.Id == typeId);
    }
}