using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.DTOs.UserDtos;
using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BookUserDtos
{
    public class BookUserAddDto : IDto
    {
        public DateTime PurchaseDate { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
