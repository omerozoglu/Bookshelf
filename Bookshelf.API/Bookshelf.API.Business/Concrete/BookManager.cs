using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly EfBookRepository efBookRepository;

        public BookManager()
        {
            efBookRepository = new EfBookRepository(); 
        }
        
        public void Create(Book obj)
        {
            efBookRepository.Create(obj);
        }

        public void Delete(Book obj)
        {
            efBookRepository.Delete(obj);
        }

        public List<Book> GetAll()
        {
            return efBookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return efBookRepository.GetById(id);
        }

        public void Update(Book obj)
        {
            efBookRepository.Update(obj);
        }
    }
}
