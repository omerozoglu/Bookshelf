using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.AuthorDtos
{
    public class AuthorAddDto : IDto
    {
        public string Name { get; set; }
    }
}
