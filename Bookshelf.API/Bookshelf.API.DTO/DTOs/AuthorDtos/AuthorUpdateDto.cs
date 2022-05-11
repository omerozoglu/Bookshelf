using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.AuthorDtos
{
    public class AuthorUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
