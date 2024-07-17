using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBookService
    {
        Task<BookDtoResponse> GetBookById(int bookId);
        Task<List<BookDtoResponse>> GetBooks();
        Task<object> AddBook(BookDtoRequest request);
        Task UpdateBook(BookDtoRequest request);
        Task DeleteBook(int bookId);
    }
}
