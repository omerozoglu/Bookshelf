using Bookshelf.API.Entities.Interfaces;

namespace Bookshelf.API.Entities.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public bool Gender { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public List<BookUser> BookUsers{ get; set; }
    }
}
