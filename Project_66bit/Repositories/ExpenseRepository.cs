using System.Collections.Generic;
using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Repositories
{
    public class ExpenseRepository : IExpenses
    {
        private readonly CategoryContext _context;
        
        public ExpenseRepository(CategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Expense> AllExpenses => _context.Expenses;
        public Expense GetExpenseById(long id) => _context.Expenses.FirstOrDefault(f => f.Id == id);
    }
}