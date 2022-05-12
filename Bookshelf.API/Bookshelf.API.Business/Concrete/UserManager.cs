using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class UserManager : GenericManager<User>, IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IGenericDal<User> genericDal, IUserDal userDal) : base(genericDal)
        {
            _userDal = userDal;
        }

        public async Task<User> LoginAsync(User user)
        {
            return await _userDal.LoginAsync(user);
        }
    }
}
