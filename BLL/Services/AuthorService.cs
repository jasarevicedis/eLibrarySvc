using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
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

        public async Task<object> AddAuthor(AuthorDtoRequest request)
        {
            Author author = new Author
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
            };
            _authorRepository.Add(author);

            await _authorRepository.SaveChangesAsync();

            var addedAuthor = _mapper.Map<AuthorDtoResponse>(author);
            return addedAuthor;
        }

        public Task DeleteAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public async Task<AuthorDtoResponse> GetAuthorById(int authorId)
        {
            var author = await _authorRepository.GetById(authorId);
            return _mapper.Map<AuthorDtoResponse>(author);
        }

        public async Task<List<AuthorDtoResponse>> GetAuthors()
        {
            var authors = await _authorRepository.GetAll();
            return _mapper.Map<List<AuthorDtoResponse>>(authors);
        }

        public async Task<AuthorDtoResponse> UpdateAuthor(AuthorDtoRequest authorRequest, int authorId)
        {
            var mappedAuthor = _mapper.Map<Author>(authorRequest);

            var author = await _authorRepository.GetById(authorId);

            _authorRepository.DetachEntity(author);
            mappedAuthor.AuthorId = authorId;
            _authorRepository.Update(mappedAuthor);

            await _authorRepository.SaveChangesAsync();

            var updatedAuthor = _mapper.Map<AuthorDtoResponse>(mappedAuthor);
            return updatedAuthor;
        }

        
    }
}
