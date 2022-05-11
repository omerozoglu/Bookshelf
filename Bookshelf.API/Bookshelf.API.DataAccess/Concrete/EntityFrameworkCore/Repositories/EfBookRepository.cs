using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBookRepository : EfGenericRepository<Book>, IBookDal
    {
        public async Task<List<Book>> GetAllBooksAsync()
        {
            using var context = new BookshelfContext();
            return await context.Books
                .Include(I => I.Genre)
                .Include(I => I.Author)
                .Include(I => I.Publisher)
                .Include(I => I.BookUsers)
                .Include(I => I.BookTransactions)
                .ToListAsync();
        }
    }
}
