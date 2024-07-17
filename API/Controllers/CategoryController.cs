using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<CategoryDtoResponse>>> GetAll()
        {
            var categories = await _categoryService.GetAll();
            return Ok(categories);
        }

        [HttpGet("get-category/{id}")]
        public async Task<ActionResult<CategoryDtoResponse>> GetCategoryById(int id)
        {
            return await _categoryService.GetCategoryById(id);
        }

        [HttpPost("add-category")]
        public async Task<ActionResult<CategoryDtoResponse>> AddCategory(CategoryDtoRequest categoryRequest) 
        {
            var newCategory = await _categoryService.AddCategory(categoryRequest);
            return Ok(newCategory);
        }

        [HttpPut("update-category/{id}")]
        public async Task<ActionResult<CategoryDtoResponse>> UpdateCategory(CategoryDtoRequest categoryRequest, int id)
        {
            var updatedCategory = await _categoryService.UpdateCategory(categoryRequest,id);
            return updatedCategory;
        }
    }
}
