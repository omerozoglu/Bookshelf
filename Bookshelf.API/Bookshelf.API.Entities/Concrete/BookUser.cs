using Bookshelf.API.Domain.Concrete;

namespace Bookshelf.API.Entities.Concrete
{
    public class BookUser : EntityBase
    {
        public DateTime? PurchaseDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool IsFav { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
