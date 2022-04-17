using Bookshelf.API.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IBookDal
    {
        void Create(Book obj);
        void Update(Book obj);
        void Delete(Book obj);
        Book GetById(int id);
        List<Book> GetAll();

    }
}
