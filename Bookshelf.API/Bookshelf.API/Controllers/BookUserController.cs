using AutoMapper;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DTO.DTOs.BookUserDtos;
using Bookshelf.API.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookUserController : ControllerBase
    {
        private readonly IBookUserService _bookUserService;
        private readonly IMapper _mapper;

        public BookUserController(IBookUserService bookUserService, IMapper mapper)
        {
            _bookUserService = bookUserService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<BookUserListDto>>(await _bookUserService.GetAllBookUsersAsync()));
        }

        [HttpGet("userBook/{id}")]
        public async Task<IActionResult> GetAllUserBooksAsync(int id)
        {
            return Ok(_mapper.Map<List<BookUserListDto>>(await _bookUserService.GetAllUserBooksAsync(id)));
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<BookUserListDto>(await _bookUserService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookUserAddDto bookUser)
        {
            await _bookUserService.AddAsync(_mapper.Map<BookUser>(bookUser));
            return Created("", bookUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BookUserUpdateDto bookUser)
        {
            if (id != bookUser.Id)
                return BadRequest("");
            await _bookUserService.UpdateAsync(_mapper.Map<BookUser>(bookUser));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookUserService.RemoveAsync(new BookUser { Id = id });
            return NoContent();
        }
    }
}
