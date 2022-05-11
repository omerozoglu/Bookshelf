using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IBookTransactionDal : IGenericDal<BookTransaction>
    {
        Task<List<BookTransaction>> GetAllBookTransactionsAsync();
        Task<List<Book>> GetLentBooksByFromUserIdAsync(int id);
        Task<List<Book>> GetBorrowedBooksByToUserIdAsync(int id);
    }
}
