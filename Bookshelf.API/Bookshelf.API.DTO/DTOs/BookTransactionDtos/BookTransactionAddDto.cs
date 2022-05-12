using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BookTransactionDtos
{
    public class BookTransactionAddDto : IDto
    {
        public DateTime LendDate { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public int BookId { get; set; }
    }
}
