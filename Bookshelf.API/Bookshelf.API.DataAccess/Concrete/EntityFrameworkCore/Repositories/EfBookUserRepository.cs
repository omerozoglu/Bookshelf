using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBookUserRepository : EfGenericRepository<BookUser>, IBookUserDal
    {
        public async Task<List<BookUser>> GetAllBookUsersAsync()
        {
            using var context = new BookshelfContext();
            return await context.BookUsers
                .Include(I => I.Book)
                .Include(I => I.User)
                .ToListAsync();
        }

        public async Task<List<Book>> GetAllUserBooksAsync(int id)
        {
            using var context = new BookshelfContext();
            return await context.BookUsers
                 .Include(I => I.Book)
                 .Include(I => I.User)
                 .Where(I => I.UserId == id)
                 .Join(context.Books, bookuser => bookuser.BookId, book => book.Id, (bookuser, book) => book)
                 .ToListAsync();
        }
    }
}
