using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRespository : IUserDal
    {
        public void Create(User obj)
        {
            using var context = new BookshelfContext();
            context.Users.Add(obj);
            context.SaveChanges();
        }

        public void Delete(User obj)
        {
            using var context = new BookshelfContext();
            context.Users.Remove(obj);
            context.SaveChanges();
        }

        public List<User> GetAll()
        {
            using var context = new BookshelfContext();
            return context.Users.ToList();
        }

        public User GetById(int id)
        {
            using var context = new BookshelfContext();
            return context.Users.Find(id);
        }

        public void Update(User obj)
        {
            using var context = new BookshelfContext();
            context.Users.Update(obj);
            context.SaveChanges();
        }
    }
}
