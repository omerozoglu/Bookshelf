using Bookshelf.API.Entities.Interfaces;

namespace Bookshelf.API.Entities.Concrete
{
    public class Publisher : ITable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<Book> Books { get; set; }

    }
}
