using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.UserDtos
{
    public class UserUpdateDto : IDto
    {
        public int Id { get; set; }
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
