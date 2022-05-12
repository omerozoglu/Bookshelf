using AutoMapper;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DTO.DTOs.AuthorDtos;
using Bookshelf.API.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorsController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<AuthorListDto>>(await _authorService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<AuthorListDto>(await _authorService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorAddDto answer)
        {
            await _authorService.AddAsync(_mapper.Map<Author>(answer));
            return Created("", answer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AuthorUpdateDto answer)
        {
            if (id != answer.Id)
                return BadRequest("");
            await _authorService.UpdateAsync(_mapper.Map<Author>(answer));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _authorService.RemoveAsync(new Author { Id = id });
            return NoContent();
        }
    }
}
