using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class BookshelfContext: DbContext
    {
        public BookshelfContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=BookshelfApiDB; Integrated Security=true;");
            optionsBuilder.UseSqlServer(@"Data Source=19.252.181.210\MSSQLSERVER2019;Database=wednesd2_bookshelf;User=wednesd2_bookshelf_admin;PWD=omerozoglu@wednesdev.W6;Integrated Security=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new BookTransactionMap());
            modelBuilder.ApplyConfiguration(new BookUserMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
            modelBuilder.ApplyConfiguration(new PublisherMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<BookTransaction>? BookTransactions { get; set; }
        public DbSet<BookUser>? BookUsers { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<Publisher>? Publishers { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
