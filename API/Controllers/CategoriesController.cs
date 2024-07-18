using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDtoResponse>>> GetAll()
        {
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDtoResponse>> GetCategoryById(int id)
        {
            return await _categoryService.GetCategoryById(id);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryDtoResponse>> AddCategory(CategoryDtoRequest categoryRequest) 
        {
            var newCategory = await _categoryService.AddCategory(categoryRequest);
            return Ok(newCategory);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryDtoResponse>> UpdateCategory(int id,CategoryDtoRequest categoryRequest)
        {
            var updatedCategory = await _categoryService.UpdateCategory(categoryRequest,id);
            return updatedCategory;
        }
    }
}
