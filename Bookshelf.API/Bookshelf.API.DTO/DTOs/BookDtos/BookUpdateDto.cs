using Bookshelf.API.DTO.DTOs.AuthorDtos;
using Bookshelf.API.DTO.DTOs.BaseDtos;
using Bookshelf.API.DTO.DTOs.GenreDtos;
using Bookshelf.API.DTO.DTOs.PublisherDtos;

namespace Bookshelf.API.DTO.DTOs.BookDtos
{
    public class BookUpdateDto : BaseUpdateDto
    {
        public string? Title { get; set; }
        public int? Edition { get; set; }
        public int? PageCount { get; set; }
        public string? ISBN { get; set; }
        public GenreUpdateDto? Genre { get; set; }
        public AuthorUpdateDto? Author { get; set; }
        public PublisherUpdateDto? Publisher { get; set; }
    }
}
