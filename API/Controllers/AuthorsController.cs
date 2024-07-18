using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AuthorDtoResponse>>> GetAll()
        {
            var authors = await _authorService.GetAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorDtoResponse>> GetAuthorById(int id)
        {
            return await _authorService.GetAuthorById(id);
        }

        [HttpPost]
        public async Task<ActionResult<AuthorDtoResponse>> AddAuthor(AuthorDtoRequest authorRequest)
        {
            var newAuthor = await _authorService.AddAuthor(authorRequest);
            return Ok(newAuthor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AuthorDtoResponse>> UpdateAuthor(int id, AuthorDtoRequest authorRequest)
        {
            var updatedAuthor = await _authorService.UpdateAuthor(authorRequest, id);
            return updatedAuthor;
        }
    }
}
