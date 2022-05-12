using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Interfaces
{
    public interface IBookService: IGenericService<Book>
    {
        Task<List<Book>> GetAllBooksAsync();
    }
}
