using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserDal
    {
        public async Task<List<User>> GetAllUsersAsync()
        {
            using var context = new BookshelfContext();
            return await context.Users
                .Include(I => I.BookUsers)
                .Include(I => I.BookTransactions)
                .ToListAsync();
        }
    }
}
