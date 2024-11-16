using librarymanagmentsystem.Data;
using librarymanagmentsystem.Entities;
using librarymanagmentsystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace librarymanagmentsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Get all Categorylist

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var allCategories = dbContext.category.ToList();
            return Ok(allCategories);
        }
        //add new category
        [HttpPost]
        public IActionResult AddCategory(AddCategory addCategoryDto)
        {
            var categoryEntity = new Category()
            {
                Name = addCategoryDto.Name,
                Description = addCategoryDto.Description


            };

            dbContext.category.Add(categoryEntity);
            dbContext.SaveChanges();
            return Ok(categoryEntity);
        }

    }
}

