using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class UserManager : GenericManager<User>, IUserService
    {
        public UserManager(IGenericDal<User> genericDal) : base(genericDal)
        {
        }
    }
}
