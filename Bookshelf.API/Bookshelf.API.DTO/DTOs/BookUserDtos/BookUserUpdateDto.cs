using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.DTOs.UserDtos;
using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BookUserDtos
{
    public class BookUserUpdateDto : IDto
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsFav { get; set; }
        public UserUpdateDto User { get; set; }
        public BookUpdateDto Book { get; set; }
    }
}
