using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_66bit.Contexts;
using Project_66bit.Models;

namespace Project_66bit.Controllers
{
    public class TypeController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly CategoryContext _db;
        
        public TypeController(ILogger<CategoryController> logger, CategoryContext db)
        {
            _db = db;
            _logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<Type> All()
        {
            return _db.Types;
        }

        [HttpGet]
        public Type Id(int id)
        {
            return _db.Types.FirstOrDefault(f => f.Id == id);
        }
    }
}