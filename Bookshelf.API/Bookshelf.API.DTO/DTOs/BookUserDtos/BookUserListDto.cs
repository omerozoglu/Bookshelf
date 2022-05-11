using Bookshelf.API.DTO.DTOs.BaseDtos;
using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.DTOs.UserDtos;
using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BookUserDtos
{
    public class BookUserListDto : BaseListDto
    {
        public DateTime PurchaseDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsFav { get; set; }
        public UserListDto User { get; set; }
        public BookListDto Book { get; set; }
    }
}
