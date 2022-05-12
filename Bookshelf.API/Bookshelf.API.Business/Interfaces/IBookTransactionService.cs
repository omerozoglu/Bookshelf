using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Interfaces
{
    public interface IBookTransactionService : IGenericService<BookTransaction>
    {
        Task<List<BookTransaction>> GetAllBookTransactionsAsync();
        Task<List<BookTransaction>> GetLentBooksByFromUserIdAsync(int id);
        Task<List<BookTransaction>> GetBorrowedBooksByToUserIdAsync(int id);
    }
}
