using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Bookshelf.API.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<T> : Interfaces.IGenericDal<T> where T : class, ITable, new()
    {
        public void Create(T obj)
        {
            using var context = new BookshelfContext();
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Delete(T obj)
        {
            using var context = new BookshelfContext();
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new BookshelfContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new BookshelfContext();
            return context.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            using var context = new BookshelfContext();
            context.Set<T>().Update(obj);
            context.SaveChanges();
        }
    }
}
