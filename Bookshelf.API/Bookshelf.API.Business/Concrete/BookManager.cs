using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class BookManager : GenericManager<Book>, IBookService
    {
        private readonly IBookDal _bookDal;
        public BookManager(IGenericDal<Book> genericDal, IBookDal bookDal) : base(genericDal)
        {
            _bookDal = bookDal;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
           return await _bookDal.GetAllBooksAsync();    
        }
    }
}
