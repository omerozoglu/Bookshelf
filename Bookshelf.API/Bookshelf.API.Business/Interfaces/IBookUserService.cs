using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Interfaces
{
    public interface IBookUserService : IGenericService<BookUser>
    {
        Task<List<BookUser>> GetAllBookUsersAsync();
        Task<List<Book>> GetAllUserBooksAsync(int id);
    }
}
