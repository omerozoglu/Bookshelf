using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class BookManager : GenericManager<Book>, IBookService
    {
        public BookManager(IGenericDal<Book> genericDal) : base(genericDal)
        {
        }
    }
}
