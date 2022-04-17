using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class UserManager : IUserService
    {

        private readonly EfUserRepository efUserRepository;

        public UserManager()
        {
            efUserRepository = new EfUserRepository();
        }
        public void Create(User obj)
        {
            efUserRepository.Create(obj);
        }

        public void Delete(User obj)
        {
            efUserRepository.Delete(obj);
        }

        public List<User> GetAll()
        {
            return efUserRepository.GetAll();
        }

        public User GetById(int id)
        {
            return efUserRepository.GetById(id);
        }

        public void Update(User obj)
        {
            efUserRepository.Update(obj);
        }
    }
}
