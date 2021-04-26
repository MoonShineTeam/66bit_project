using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_66bit.Contexts;
using Project_66bit.Interfaces;
using Project_66bit.Models;
using Project_66bit.Repositories;
using Type = Project_66bit.Models.Type;

namespace Project_66bit.Controllers
{
    
    [Produces("application/json")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ITypes _type;
        private readonly ICategories _repo;

        public CategoryController(ILogger<CategoryController> logger, ICategories categories, ITypes types)
        {
            //_db = db;
            _type = types;
            _logger = logger;
            _repo = categories;
        }
        
        [HttpGet]
        public IEnumerable<Category> All()
        {
            return _repo.AllCategories;
        }
        
        [HttpGet]
        public Category Id(long id)
        {
            if (id < 1 || id > _repo.AllCategories.Count())
                throw new Exception("Invalid id");
            return _repo.GetCategoryById(id);
        }
        
        [HttpGet]
        public IEnumerable<Category> TypeId(long id)
        {
            if (id < 1 || id > _type.AllTypes.Count())
                throw new Exception("Invalid id");
            return _repo.GetCategoriesByType(id);
        }
    }
}