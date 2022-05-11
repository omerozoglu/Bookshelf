using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBookTransactionRepository : EfGenericRepository<BookTransaction>, IBookTransactionDal
    {
        public Task<List<BookTransaction>> GetAllBookTransactionsAsync()
        {
            using var context = new BookshelfContext();
            return context.BookTransactions
                .Include(I => I.Book)
                .ToListAsync();
        }

        public async Task<List<Book>> GetBorrowedBooksByToUserIdAsync(int id)
        {
            using var context = new BookshelfContext();
            return await context.BookTransactions
                .Include(I => I.Book)
                .Where(I => I.ToUserId == id && I.ReturnedDate.Value == null)
                .Join(context.Books, bookTransaction => bookTransaction.BookId, book => book.Id,(bookTransaction,book)=>book)
                .ToListAsync();
        }

        public async Task<List<Book>> GetLentBooksByFromUserIdAsync(int id)
        {
            using var context = new BookshelfContext();
            return await context.BookTransactions
                .Include(I => I.Book)
                .Where(I => I.FromUserId == id && I.ReturnedDate.Value == null)
                .Join(context.Books, bookTransaction => bookTransaction.BookId, book => book.Id, (bookTransaction, book) => book)
                .ToListAsync();
        }
    }
}
