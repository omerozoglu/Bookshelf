using Bookshelf.API.DTO.DTOs.BaseDtos;
using Bookshelf.API.DTO.DTOs.BookDtos;

namespace Bookshelf.API.DTO.DTOs.BookTransactionDtos
{
    public class BookTransactionListDto : BaseListDto
    {
        public DateTime LendDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public BookListDto Book { get; set; }
    }
}
