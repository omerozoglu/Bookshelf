using AutoMapper;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(_mapper.Map<List<BookListDto>>(await _bookService.GetAllBooksAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<BookListDto>(await _bookService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookAddDto book)
        {
            await _bookService.AddAsync(_mapper.Map<Book>(book));
            return Created("", book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BookUpdateDto book)
        {
            if (id != book.Id)
                return BadRequest("");
            await _bookService.UpdateAsync(_mapper.Map<Book>(book));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookService.RemoveAsync(new Book { Id = id });
            return NoContent();
        }
    }
}
