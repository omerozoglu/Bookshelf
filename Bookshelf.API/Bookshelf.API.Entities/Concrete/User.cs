using Bookshelf.API.Domain.Concrete;

namespace Bookshelf.API.Entities.Concrete
{
    public class User : EntityBase
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
        public List<BookUser> BookUsers{ get; set; }
        public List<BookTransaction> BookTransactions { get; set; }
    }
}
