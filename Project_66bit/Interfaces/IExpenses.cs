using System.Collections.Generic;
using Project_66bit.Models;

namespace Project_66bit.Interfaces
{
    public interface IExpenses
    {
        IEnumerable<Expense> AllExpenses { get; }
        Expense GetExpenseById(long id);
    }
}