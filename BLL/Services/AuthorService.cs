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
    public class AuthorService: IAuthorService
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IMapper mapper, IAuthorRepository authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }

        public Task<object> AddAuthor(AuthorDtoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDtoResponse> GetAuthorById(int authorId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuthorDtoResponse>> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAuthor(AuthorDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
