using System.Collections.Generic;
using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Repositories
{
    public class TypeRepository : ITypes
    {
        private readonly CategoryContext _db;

        public TypeRepository(CategoryContext db)
        {
            _db = db;
        }
        
        public IEnumerable<Type> AllTypes => _db.Types;

        public Type GetTypeById(int typeId) => _db.Types.FirstOrDefault(f => f.Id == typeId);
    }
}