using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IBookUserDal : IGenericDal<BookUser>
    {
        Task<List<BookUser>> GetAllBookUsersAsync();
        Task<List<Book>> GetAllUserBooksAsync(int id);
    }
}
