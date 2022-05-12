using Bookshelf.API.DTO.DTOs.AuthorDtos;
using Bookshelf.API.DTO.DTOs.GenreDtos;
using Bookshelf.API.DTO.DTOs.PublisherDtos;
using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BookDtos
{
    public class BookAddDto : IDto
    {
        public string Title { get; set; }
        public int Edition { get; set; }
        public int PageCount { get; set; }
        public string ISBN { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }
}
