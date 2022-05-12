using AutoMapper;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.DTOs.BookTransactionDtos;
using Bookshelf.API.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTransactionController : ControllerBase
    {
        private readonly IBookTransactionService _bookTransactionService;
        private readonly IMapper _mapper;

        public BookTransactionController(IBookTransactionService bookTransactionService, IMapper mapper)
        {
            _bookTransactionService = bookTransactionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<BookTransactionListDto>>(await _bookTransactionService.GetAllAsync()));
        }

        [HttpGet("getLentBooks/{id}")]
        public async Task<IActionResult> GetLentBooksByFromUserId(int id)
        {
            var temp = _mapper.Map<List<BookTransactionListDto>>(await _bookTransactionService.GetLentBooksByFromUserIdAsync(id));
            return Ok(temp);
        }

        [HttpGet("getBorrowedBooks/{id}")]
        public async Task<IActionResult> GetBorrowedBooksByFromUserId(int id)
        {
            return Ok(_mapper.Map<List<BookTransactionListDto>>(await _bookTransactionService.GetBorrowedBooksByToUserIdAsync(id)));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<BookTransactionListDto>(await _bookTransactionService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookTransactionAddDto bookTransaction)
        {
            await _bookTransactionService.AddAsync(_mapper.Map<BookTransaction>(bookTransaction));
            return Created("", bookTransaction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BookTransactionUpdateDto bookTransaction)
        {
            if (id != bookTransaction.Id)
                return BadRequest("");
            await _bookTransactionService.UpdateAsync(_mapper.Map<BookTransaction>(bookTransaction));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookTransactionService.RemoveAsync(new BookTransaction { Id = id });
            return NoContent();
        }

    }
}
