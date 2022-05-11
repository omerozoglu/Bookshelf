using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class BookUserManager : GenericManager<BookUser>, IBookUserService
    {
        public BookUserManager(IGenericDal<BookUser> genericDal) : base(genericDal)
        {
        }
    }
}
