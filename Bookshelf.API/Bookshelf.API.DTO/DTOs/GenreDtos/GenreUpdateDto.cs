using Bookshelf.API.DTO.DTOs.BaseDtos;

namespace Bookshelf.API.DTO.DTOs.GenreDtos
{
    public class GenreUpdateDto : BaseUpdateDto
    {
        public string? Name { get; set; }
    }
}
