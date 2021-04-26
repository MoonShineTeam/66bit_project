using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_66bit.Contexts;
using Project_66bit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_66bit.Interfaces;

namespace Project_66bit.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUsers _repo;

        public UserController(ILogger<UserController> logger, IUsers users)
        {
            _logger = logger;
            _repo = users;
        }

        [HttpGet]
        public IEnumerable<User> All() => _repo.AllUsers;
        
        [HttpGet]
        public User Id(int id) => _repo.GetUserById(id);
    }
}
