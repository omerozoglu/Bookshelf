using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.UserDtos
{
    public class UserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
