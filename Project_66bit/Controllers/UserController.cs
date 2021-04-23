using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_66bit.Contexts;
using Project_66bit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_66bit.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ExpenseContext _db;

        public UserController(ILogger<UserController> logger, ExpenseContext db)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> All() => _db.Users;
    }
}
