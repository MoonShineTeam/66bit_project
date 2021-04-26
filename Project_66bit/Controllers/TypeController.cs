using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Controllers
{
    public class TypeController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ITypes _repo;
        
        public TypeController(ILogger<CategoryController> logger, ITypes types)
        {
            _repo = types;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Type> All() => _repo.AllTypes;

        [HttpGet]
        public Type Id(long id) => _repo.GetTypeById(id);

        /*[HttpGet]
        public IEnumerable<Expense> Expenses(long id) => _repo.GetExpensesByType(id);*/
    }
}