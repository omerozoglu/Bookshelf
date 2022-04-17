using Bookshelf.API.Entities.Interfaces;

namespace Bookshelf.API.Entities.Concrete
{
    public class Borrow : ITable
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public int BookId { get; set; }
        public DateTime GetDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
