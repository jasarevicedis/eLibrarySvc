using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDtoResponse> GetCategoryById(int id);
        Task<List<CategoryDtoResponse>> GetAll();
        Task<CategoryDtoResponse> AddCategory(CategoryDtoRequest categoryDtoRequest);
        Task<CategoryDtoResponse> UpdateCategory(CategoryDtoRequest categoryDtoRequest, int categoryId);
        Task DeleteCategory(int categoryId);
    }
}
