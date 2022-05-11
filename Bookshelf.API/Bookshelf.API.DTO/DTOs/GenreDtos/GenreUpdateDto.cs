using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.GenreDtos
{
    public class GenreUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
