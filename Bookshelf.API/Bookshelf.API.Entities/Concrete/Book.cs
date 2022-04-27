using Bookshelf.API.Entities.Interfaces;

namespace Bookshelf.API.Entities.Concrete
{
    public class Book : ITable
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public int Edition { get; set; }
        public Int16 PageCount { get; set; }
        public int Bookmark { get; set; }
        public string? ISBN { get; set; }
        public bool IsDeleted { get; set; }
        public int GenreID { get; set; }
        public Genre? Genre { get; set; }
        public Author? Author { get; set; }
        public Publisher? Publisher { get; set; }
        public List<BookUser> BookUsers { get; set; }  

    }
}
