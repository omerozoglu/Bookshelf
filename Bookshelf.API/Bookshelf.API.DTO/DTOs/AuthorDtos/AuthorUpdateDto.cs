using Bookshelf.API.DTO.DTOs.BaseDtos;

namespace Bookshelf.API.DTO.DTOs.AuthorDtos
{
    public class AuthorUpdateDto : BaseUpdateDto
    {
        public string? Name { get; set; }
    }
}
