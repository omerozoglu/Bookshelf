using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class AuthorManager : GenericManager<Author>, IAuthorService
    {
        public AuthorManager(IGenericDal<Author> genericDal) : base(genericDal)
        {
        }
    }
}
