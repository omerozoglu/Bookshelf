using Bookshelf.API.DTO.DTOs.AuthorDtos;
using Bookshelf.API.DTO.DTOs.BaseDtos;
using Bookshelf.API.DTO.DTOs.GenreDtos;
using Bookshelf.API.DTO.DTOs.PublisherDtos;

namespace Bookshelf.API.DTO.DTOs.BookDtos
{
    public class BookListDto : BaseListDto
    {
        public string Title { get; set; }
        public int Edition { get; set; }
        public int PageCount { get; set; }
        public int Bookmark { get; set; }
        public string ISBN { get; set; }
        public GenreListDto Genre { get; set; }
        public AuthorListDto Author { get; set; }
        public PublisherListDto Publisher { get; set; }
    }
}
