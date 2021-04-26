using System.Collections.Generic;
using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Repositories
{
    public class UserRepository : IUsers
    {
        private readonly CategoryContext _context;
        
        public UserRepository(CategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<User> AllUsers => _context.Users;
        public User GetUserById(long id) => _context.Users.FirstOrDefault(f => f.Id == id);
    }
}