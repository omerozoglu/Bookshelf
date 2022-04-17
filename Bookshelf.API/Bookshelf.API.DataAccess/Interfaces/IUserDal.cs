using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IUserDal
    {
        void Create(User obj);
        void Update(User obj);
        void Delete(User obj);
        User GetById(int id); 
        List<User> GetAll();
    }
}
