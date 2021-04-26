using System.Collections.Generic;
using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Repositories
{
    public class BillRepository : IBills
    {
        private readonly CategoryContext _context;
        
        public BillRepository(CategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Bill> AllBills => _context.Bills;
        public Bill GetBillById(long id) => _context.Bills.FirstOrDefault(f => f.Id == id);

        public Bill GetBillByUserId(long userId) => _context.Bills.FirstOrDefault(f => f.UserId == userId);
    }
}