using Bookshelf.API.Domain.Concrete;

namespace Bookshelf.API.Entities.Concrete
{
    public class Book : EntityBase
    {
        public string? Title { get; set; }
        public int? Edition { get; set; }
        public int? PageCount { get; set; }
        public int? Bookmark { get; set; }
        public string? ISBN { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookUser> BookUsers { get; set; }
        public List<BookTransaction> BookTransactions { get; set; }

    }
}
