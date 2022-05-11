using Bookshelf.API.DTO.DTOs.BaseDtos;

namespace Bookshelf.API.DTO.DTOs.UserDtos
{
    public class UserListDto : BaseListDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public bool IsActive { get; set; }
    }
}
