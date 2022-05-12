using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class BookTransactionManager : GenericManager<BookTransaction>, IBookTransactionService
    {
        private readonly IBookTransactionDal _bookTransactionDal;
        public BookTransactionManager(IGenericDal<BookTransaction> genericDal, IBookTransactionDal bookTransactionDal) : base(genericDal)
        {
            _bookTransactionDal = bookTransactionDal;
        }

        public async Task<List<BookTransaction>> GetAllBookTransactionsAsync()
        {
            return await _bookTransactionDal.GetAllBookTransactionsAsync();
        }

        public async Task<List<BookTransaction>> GetBorrowedBooksByToUserIdAsync(int id)
        {
            return await _bookTransactionDal.GetBorrowedBooksByToUserIdAsync(id);
        }

        public async Task<List<BookTransaction>> GetLentBooksByFromUserIdAsync(int id)
        {
            return await _bookTransactionDal.GetLentBooksByFromUserIdAsync(id);
        }
    }
}
