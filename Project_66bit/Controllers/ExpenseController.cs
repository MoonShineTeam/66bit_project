using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Controllers
{
    public class ExpenseController
    {
        private readonly IExpenses _repo;

        public ExpenseController(IExpenses repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Expense> All() => _repo.AllExpenses;

        [HttpGet]
        public Expense Id(long id) => _repo.GetExpenseById(id);
    }
}