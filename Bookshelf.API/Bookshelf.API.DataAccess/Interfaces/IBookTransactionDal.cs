using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IBookTransactionDal : IGenericDal<BookTransaction>
    {
        Task<List<BookTransaction>> GetAllBookTransactionsAsync();
        Task<List<BookTransaction>> GetLentBooksByFromUserIdAsync(int id);
        Task<List<BookTransaction>> GetBorrowedBooksByToUserIdAsync(int id);
    }
}
