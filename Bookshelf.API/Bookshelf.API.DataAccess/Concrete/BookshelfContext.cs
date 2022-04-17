using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.API.DataAccess.Concrete
{
    public class BookshelfContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=BookshelfApiDB; Integrated Security=true;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
