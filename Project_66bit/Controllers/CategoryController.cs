using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_66bit.Contexts;
using Project_66bit.Models;
using Project_66bit.Repositories;
using Type = Project_66bit.Models.Type;

namespace Project_66bit.Controllers
{
    
    [Produces("application/json")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly CategoryContext _db;
        //private readonly CategoryRepository _repo;

        public CategoryController(ILogger<CategoryController> logger, CategoryContext db)
        {
            _db = db;
            _logger = logger;
            //_repo = catRepo;
        }
        
        [HttpGet]
        public IEnumerable<Category> All()
        {
            return _db.Categories;
        }
        
        [HttpGet]
        public Category Id(int id)
        {
            if (id < 1 || id > _db.Categories.Count())
                throw new Exception("Invalid id");
            return _db.Categories.FirstOrDefault(f => f.Id == id);
        }
        
        [HttpGet]
        public IEnumerable<Category> TypeId(int id)
        {
            if (id < 1 || id > _db.Types.Count())
                throw new Exception("Invalid id");
            return _db.Categories.Where(f => f.TypeId == id);
        }
    }
}