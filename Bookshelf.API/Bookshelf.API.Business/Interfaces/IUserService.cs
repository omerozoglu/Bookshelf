using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> LoginAsync(User user);
    }
}
