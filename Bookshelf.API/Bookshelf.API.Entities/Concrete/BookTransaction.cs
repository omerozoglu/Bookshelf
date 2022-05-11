using Bookshelf.API.Domain.Concrete;

namespace Bookshelf.API.Entities.Concrete
{
    public class BookTransaction : EntityBase
    {
        public DateTime? LendDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
