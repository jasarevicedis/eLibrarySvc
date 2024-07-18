using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDtoResponse>> GetCategories()
        {
            var categories = await _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryDtoResponse>>(categories);
        }

        public async Task<CategoryDtoResponse> GetCategoryById(int id)
        {
            var category = await _categoryRepository.GetById(id);
            return _mapper.Map<CategoryDtoResponse>(category);
        }

        public async Task DeleteCategory(int categoryId)
        {

        }
        public async Task<CategoryDtoResponse> AddCategory(CategoryDtoRequest categoryRequest)
        {
            Category category = new Category {
                Name = categoryRequest.Name
            };
            _categoryRepository.Add(category);

            await _categoryRepository.SaveChangesAsync();

            var addedCategory = _mapper.Map<CategoryDtoResponse>(category);
            return addedCategory;
        }

        public async Task<CategoryDtoResponse> UpdateCategory(CategoryDtoRequest categoryRequest, int categoryId)
        {
            var mappedCategory = _mapper.Map<Category>(categoryRequest);

            var category = await _categoryRepository.GetById(categoryId);

            _categoryRepository.DetachEntity(category);
            mappedCategory.CategoryId = categoryId;
            _categoryRepository.Update(mappedCategory);

            await _categoryRepository.SaveChangesAsync();

            var updatedCategory = _mapper.Map<CategoryDtoResponse>(mappedCategory);
            return updatedCategory;
            
        }
    }
}
