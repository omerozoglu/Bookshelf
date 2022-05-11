using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BookTransactionDtos
{
    public class BookTransactionUpdateDto : IDto
    {
        public int Id { get; set; }
        public DateTime LendDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public BookUpdateDto Book { get; set; }
    }
}
