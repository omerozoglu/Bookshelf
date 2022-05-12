using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class BookUserManager : GenericManager<BookUser>, IBookUserService
    {
        private readonly IBookUserDal _bookUserDal;
        public BookUserManager(IGenericDal<BookUser> genericDal, IBookUserDal bookUserDal) : base(genericDal)
        {
            _bookUserDal = bookUserDal;
        }

        public async Task<List<BookUser>> GetAllBookUsersAsync()
        {
            return await _bookUserDal.GetAllBookUsersAsync();
        }

        public async Task<List<Book>> GetAllUserBooksAsync(int id)
        {
            return await _bookUserDal.GetAllUserBooksAsync(id);
        }
    }
}
