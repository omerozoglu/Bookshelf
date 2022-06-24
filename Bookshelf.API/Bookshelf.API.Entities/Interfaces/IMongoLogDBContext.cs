using MongoDB.Driver;

namespace Bookshelf.API.Entities.Concrete.Interfaces
{
    public interface IMongoLogDBContext
    {
        IMongoCollection<Log> GetCollection<Book>(string name);
    }
}
