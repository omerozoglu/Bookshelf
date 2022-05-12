using Bookshelf.API.DTO.DTOs.BaseDtos;
using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.DTOs.UserDtos;

namespace Bookshelf.API.DTO.DTOs.BookUserDtos
{
    public class BookUserUpdateDto : BaseUpdateDto
    {
        public DateTime? PurchaseDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool? IsFav { get; set; }
        public int? UserId { get; set; }
        public int? BookId { get; set; }
    }
}
