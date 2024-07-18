using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAuthorService
    {
        Task<AuthorDtoResponse> GetAuthorById(int authorId);
        Task<List<AuthorDtoResponse>> GetAuthors();
        //Task<List<AuthorDtoResponse>> GetAuthorsForBook(int bookId);
        Task<object> AddAuthor(AuthorDtoRequest request);
        Task<AuthorDtoResponse> UpdateAuthor(AuthorDtoRequest request, int authorId);
        Task DeleteAuthor(int authorId);
    }
}
