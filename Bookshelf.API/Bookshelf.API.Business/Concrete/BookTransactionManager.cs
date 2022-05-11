using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class BookTransactionManager : GenericManager<BookTransaction>, IBookTransactionService
    {
        public BookTransactionManager(IGenericDal<BookTransaction> genericDal) : base(genericDal)
        {
        }
    }
}
