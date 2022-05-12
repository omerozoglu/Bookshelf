using AutoMapper;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DTO.DTOs.GenreDtos;
using Bookshelf.API.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        private readonly IMapper _mapper;
        public GenreController(IGenreService genreService, IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<GenreListDto>>(await _genreService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<GenreListDto>(await _genreService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenreAddDto genre)
        {
            await _genreService.AddAsync(_mapper.Map<Genre>(genre));
            return Created("", genre);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, GenreUpdateDto genre)
        {
            if (id != genre.Id)
                return BadRequest("");
            await _genreService.UpdateAsync(_mapper.Map<Genre>(genre));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genreService.RemoveAsync(new Genre { Id = id });
            return NoContent();
        }
    }
}
