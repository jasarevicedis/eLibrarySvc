using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookService: IBookService
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public BookService()
        {
        }

        public Task<object> AddBook(BookDtoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task<BookDtoResponse> GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookDtoResponse>> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBook(BookDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
