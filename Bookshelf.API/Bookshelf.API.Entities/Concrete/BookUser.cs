using Bookshelf.API.Entities.Interfaces;

namespace Bookshelf.API.Entities.Concrete
{
    public class BookUser : ITable
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsBorrow { get; set; }
        public bool IsLend { get; set; }
        public bool IsFav { get; set; }
        public bool IsDeleted { get; set; }

        public Book? Book { get; set; }
        public User? User { get; set; }

    }
}
