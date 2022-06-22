using AutoMapper;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DTO.DTOs.UserDtos;
using Bookshelf.API.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Logger.NLogger nLogger = new Logger.NLogger();
            nLogger.LogWithNLog("User Getall");
            return Ok(_mapper.Map<List<UserListDto>>(await _userService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<UserListDto>(await _userService.FindById(id)));
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UserLoginDto user)
        {
            User loggedUser = await _userService.LoginAsync(_mapper.Map<User>(user));
            if (loggedUser == null)
                return BadRequest();
            return Created("", loggedUser);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserAddDto user)
        {
            await _userService.AddAsync(_mapper.Map<User>(user));
            return Created("", user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UserUpdateDto user)
        {
            if (id != user.Id)
                return BadRequest("");
            await _userService.UpdateAsync(_mapper.Map<User>(user));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.RemoveAsync(new User { Id = id });
            return NoContent();
        }
    }
}
