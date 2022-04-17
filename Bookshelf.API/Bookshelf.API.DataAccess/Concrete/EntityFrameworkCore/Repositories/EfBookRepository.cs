using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBookRepository : IBookDal
    {
        public void Create(Book obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book obj)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int i)
        {
            throw new NotImplementedException();
        }

        public void Update(Book obj)
        {
            throw new NotImplementedException();
        }
    }
}
