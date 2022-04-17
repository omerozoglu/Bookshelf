using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBookRepository : IBookDal
    {
        public void Create(Book obj)
        {
            using var context = new BookshelfContext();
            context.Books.Add(obj);
            context.SaveChanges();
        }

        public void Delete(Book obj)
        {
            using var context = new BookshelfContext();
            context.Books.Remove(obj);
            context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            using var context = new BookshelfContext();
            return context.Books.ToList();
        }

        public Book GetById(int id)
        {
            using var context = new BookshelfContext();
            return context.Books.Find(id);
        }

        public void Update(Book obj)
        {
            using var context = new BookshelfContext();
            context.Books.Update(obj);
            context.SaveChanges();
        }
    }
}
